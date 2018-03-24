using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevenAlpha
{
    public partial class BookingsManager : Form
    {
        ElevenAlphaEntities context;
        MemberLookup memberLookup;
        BookingTab parent;

        public BookingsManager(BookingTab parent, string facilityName, DateTime bookingDate)
        {
            InitializeComponent();

            // Reference parent
            this.parent = parent;

            // Initialize DB context
            context = new ElevenAlphaEntities();

            // Initialize values based on slot selected
            FacilityTypeComboBox.Text = facilityName;
            BookingDateTimePicker.Value = bookingDate;

            // Initialize watermark
            FirstNameTextBox_TextChanged(FirstNameTextBox, new EventArgs());
            LastNameTextBox_TextChanged(LastNameTextBox, new EventArgs());

            // Initialize comboBox Collection
            InitializeFacilityTypeComboBox();

            // Initialize dataGrid
            LoadBookingDataGrid();
        }

        private void LoadBookingDataGrid()
        {
            // Check if there are Facilities that match Facility Type
            if (context.Facilities.Where(x => x.FacilityType.Name == FacilityTypeComboBox.Text && x.Active == 1).FirstOrDefault() is null)
            {
                BookingManagerDataGrid.Rows.Clear();
                BookingManagerDataGrid.Columns.Clear();
                MessageBox.Show("There are no Facilities associated with this Facility Type.");
                return;
            }

            // Get opening time
            DateTime openingTime = context.Facilities
                .Where(x => x.FacilityType.Name == FacilityTypeComboBox.Text)
                .Min(x => x.OpeningTime).Value;

            // Get closing time
            DateTime closingTime = context.Facilities
                .Where(x => x.FacilityType.Name == FacilityTypeComboBox.Text)
                .Max(x => x.ClosingTime).Value;

            // Get Facilities that match Facility Type
            var matchingFacilities = context.Facilities
                .Where(x => x.FacilityType.Name == FacilityTypeComboBox.Text
                    && x.Active == 1)
                .ToList();

            int noOfFacilities = matchingFacilities.Count();
            int noOfSlots = (closingTime - openingTime).Hours;

            // Will default to 1 if calendar is selected wrongly.
            BookingManagerDataGrid.ColumnCount = noOfFacilities;
            BookingManagerDataGrid.RowCount = noOfSlots;

            // Remove sorting
            foreach (DataGridViewColumn column in BookingManagerDataGrid.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;


            // Fill opening hours
            for (int i = 0; i < noOfSlots; i++)
            {
                BookingManagerDataGrid.Rows[i].HeaderCell.Value =
                    $"{openingTime.Hour + i}:00 - {openingTime.AddHours(1).Hour + i}:00";
            }

            // Fill Facilities
            for (int i = 0; i < noOfFacilities; i++)
            {
                BookingManagerDataGrid.Columns[i].HeaderCell.Value = matchingFacilities[i].Name;
            }

            // Fill Status
            for (int i = 0; i < noOfFacilities; i++)
            {
                for (int j = 0; j < noOfSlots; j++)
                {
                    int yearComparison = BookingDateTimePicker.Value.Year;
                    int monthComparison = BookingDateTimePicker.Value.Month;
                    int dayComparison = BookingDateTimePicker.Value.Day;

                    string facilityName = BookingManagerDataGrid.Columns[i].HeaderCell.Value.ToString();

                    // Get List of Bookings that match FacilityName, BookingDate, TimeSlot and are not cancelled
                    var booking = context.Bookings
                        .Where(x => x.Facility.Name == facilityName &&
                            x.BookingDate.Value.Year == yearComparison &&
                            x.BookingDate.Value.Month == monthComparison &&
                            x.BookingDate.Value.Day == dayComparison &&
                            x.Timeslot == j &&
                            x.Status == 1)
                        .FirstOrDefault();

                    if (booking is null)
                    {
                        BookingManagerDataGrid.Rows[j].Cells[i].Value = "Vacant";
                        BookingManagerDataGrid.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(198, 239, 206);
                        BookingManagerDataGrid.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(0, 97, 0);
                    }
                    else
                    {
                        BookingManagerDataGrid.Rows[j].Cells[i].Value = $"{booking.Member.FirstName} {booking.Member.LastName}";
                        BookingManagerDataGrid.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(255, 199, 206);
                        BookingManagerDataGrid.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(156, 0, 6);
                    }
                }
            }
        }

        private void InitializeFacilityTypeComboBox()
        {
            var list = context.FacilityTypes
                .Where(x => x.Active == 1)
                .ToList();

            foreach (var item in list)
            {
                FacilityTypeComboBox.Items.Add(item.Name);
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length == 0)
            {
                FirstNameTextBox.BackColor = SystemColors.Control;
                FirstNameTextBox.ForeColor = SystemColors.GrayText;
                //FirstNameTextBox.Font = new Font(FirstNameTextBox.Font, FontStyle.Italic);
                FirstNameTextBox.Text = "First Name";
            }
            else if (FirstNameTextBox.Text != "First Name")
            {
                FirstNameTextBox.BackColor = SystemColors.Control;
                FirstNameTextBox.ForeColor = SystemColors.ControlText;
                //FirstNameTextBox.Font = new Font(FirstNameTextBox.Font, FirstNameTextBox.Font.Style & ~FontStyle.Italic);
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length == 0)
            {
                LastNameTextBox.BackColor = SystemColors.Control;
                LastNameTextBox.ForeColor = SystemColors.GrayText;
                //LastNameTextBox.Font = new Font(LastNameTextBox.Font, FontStyle.Italic);
                LastNameTextBox.Text = "Last Name";
            }
            else if (LastNameTextBox.Text != "Last Name")
            {
                LastNameTextBox.BackColor = SystemColors.Control;
                LastNameTextBox.ForeColor = SystemColors.ControlText;
                //LastNameTextBox.Font = new Font(LastNameTextBox.Font, FirstNameTextBox.Font.Style & ~FontStyle.Italic);
            }
        }

        private void MemberIdTextBox_TextChanged(object sender, EventArgs e)
        {
            int memberId;

            if (MemberIdTextBox.Text == "") { }
            else if (Int32.TryParse(MemberIdTextBox.Text, out memberId))
            {
                if (context.Members.Where(x => x.MemberID == memberId).FirstOrDefault() is null)
                {
                    FirstNameTextBox.Text = "";
                    LastNameTextBox.Text = "";
                }
                else
                {
                    FirstNameTextBox.Text = context.Members.Where(x => x.MemberID == memberId).First().FirstName;
                    LastNameTextBox.Text = context.Members.Where(x => x.MemberID == memberId).First().LastName;
                }

            }
            else
            {
                MessageBox.Show("You have entered an invalid Member ID.");
                MemberIdTextBox.Text = "";
            }
        }

        private void ShowMemberLookupButton_Click(object sender, EventArgs e)
        {
            memberLookup = new MemberLookup(this);
            memberLookup.ShowDialog();
        }

        private void BookingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingDataGrid();
        }

        private void PreviousDayButton_Click(object sender, EventArgs e)
        {
            BookingDateTimePicker.Value = BookingDateTimePicker.Value.AddDays(-1);
        }

        private void NextDayButton_Click(object sender, EventArgs e)
        {
            BookingDateTimePicker.Value = BookingDateTimePicker.Value.AddDays(1);
        }

        private void FacilityTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBookingDataGrid();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            if (BookingManagerDataGrid.SelectedCells[0].Value.ToString() != "Vacant")
            {
                MessageBox.Show("Cannot book timeslot that has already been booked.");
                return;
            }

            if (MemberIdTextBox.Text == "")
            {
                MessageBox.Show("Member ID is a required field.");
                return;
            }

            string facility = BookingManagerDataGrid.SelectedCells[0].OwningColumn.HeaderText;
            int facilityId = context.Facilities.Where(x => x.Name == facility).FirstOrDefault().FacilityID;

            Booking b = new Booking()
            {
                FacilityID = facilityId,
                MemberID = Int32.Parse(MemberIdTextBox.Text),
                BookingDate = BookingDateTimePicker.Value,
                Timeslot = BookingManagerDataGrid.SelectedCells[0].RowIndex,
                Status = 1,
                DateRequested = System.DateTime.Now
            };

            context.Bookings.Add(b);
            context.SaveChanges();

            LoadBookingDataGrid();
            parent.LoadBookingDataGrid();
            MessageBox.Show($"Booking successful!{Environment.NewLine}{MemberIdTextBox.Text}{Environment.NewLine}{facility}{Environment.NewLine}{BookingDateTimePicker.Value}{Environment.NewLine}{BookingManagerDataGrid.SelectedCells[0].OwningRow.HeaderCell.Value.ToString()}");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}