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
    public partial class BookingHistoryMembers : Form
    {
        ElevenAlphaEntities context;

        public BookingHistoryMembers(int memberId, DateTime fromDateTime, DateTime toDateTime)
        {
            InitializeComponent();
            context = new ElevenAlphaEntities();

            MemberIdTextBox.Text = memberId.ToString();

            // Initialize DateTimePicker
            FromDateTimePicker.Value = fromDateTime;
            ToDateTimePicker.Value = toDateTime;

            // Initialize watermark
            FirstNameTextBox_TextChanged(FirstNameTextBox, new EventArgs());
            LastNameTextBox_TextChanged(LastNameTextBox, new EventArgs());
        }

        private void LoadBookingHistoryDataGrid()
        {
            int memberId = -1;

            if (MemberIdTextBox.Text != "" && !Int32.TryParse(MemberIdTextBox.Text, out memberId))
            {
                MessageBox.Show("Invalid Member ID.");
                return;
            }

            if (ShowCancelledCheckBox.Checked)
            {
                BookingMemberDataGrid.DataSource = context.Bookings
                    .Where(x => x.MemberID == memberId &&
                        x.BookingDate.Value >= FromDateTimePicker.Value &&
                        x.BookingDate.Value <= ToDateTimePicker.Value &&
                        (x.FacilityID.Value.ToString().Contains(SearchTextBox.Text) ||
                        x.Facility.Name.Contains(SearchTextBox.Text) ||
                        x.Facility.FacilityType.Name.Contains(SearchTextBox.Text) ||
                        x.BookingID.ToString().Contains(SearchTextBox.Text)))
                    .OrderByDescending(x => x.BookingDate)
                    .Select(x => new
                    {
                        x.BookingID,
                        x.DateRequested,
                        x.BookingDate,
                        x.Timeslot,
                        x.FacilityID,
                        FacilityName = x.Facility.Name,
                        FacilityTypeName = x.Facility.FacilityType.Name,
                        Status = x.Status == 1 ? "Booked" : "Cancelled"
                    })
                    .ToList();
            }
            else
            {
                BookingMemberDataGrid.DataSource = context.Bookings
                    .Where(x => x.MemberID == memberId &&
                        x.BookingDate.Value >= FromDateTimePicker.Value &&
                        x.BookingDate.Value <= ToDateTimePicker.Value &&
                        x.Status == 1 &&
                        (x.FacilityID.Value.ToString().Contains(SearchTextBox.Text) ||
                        x.Facility.Name.Contains(SearchTextBox.Text) ||
                        x.Facility.FacilityType.Name.Contains(SearchTextBox.Text) ||
                        x.BookingID.ToString().Contains(SearchTextBox.Text)))
                    .OrderByDescending(x => x.BookingDate)
                    .Select(x => new
                    {
                        x.BookingID,
                        x.DateRequested,
                        x.BookingDate,
                        x.Timeslot,
                        x.FacilityID,
                        FacilityName = x.Facility.Name,
                        FacilityTypeName = x.Facility.FacilityType.Name,
                        Status = x.Status == 1 ? "Booked" : "Cancelled"
                    })
                    .ToList();
            }

            foreach (DataGridViewColumn column in BookingMemberDataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void MemberIdTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();

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

        private void ViewReceiptButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            if (BookingMemberDataGrid.SelectedCells[7].Value.ToString() == "Cancelled")
            {
                MessageBox.Show("Booking has already been cancelled.");
                return;
            }

            DateTime selectedDate = (DateTime)BookingMemberDataGrid.SelectedCells[2].Value;
            DateTime compareDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 0, 0, 0);

            if (compareDate.CompareTo(System.DateTime.Now) == -1)
            {
                MessageBox.Show("Cannot cancel past booking.");
                return;
            }

            int bookingId = Int32.Parse(BookingMemberDataGrid.SelectedCells[0].Value.ToString());
            Booking b = context.Bookings.Where(x => x.BookingID == bookingId).First();

            b.Status = 0;
            context.SaveChanges();

            LoadBookingHistoryDataGrid();
            MessageBox.Show("Booking has been cancelled.");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void ShowCancelledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
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
    }
}
