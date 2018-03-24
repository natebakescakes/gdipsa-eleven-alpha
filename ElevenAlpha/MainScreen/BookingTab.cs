using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevenAlpha
{
    public partial class BookingTab : UserControl
    {
        ElevenAlphaEntities context;

        public BookingTab()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            context = new ElevenAlphaEntities();
            LoadFacilityTypes();
        }

        /// <summary>
        /// Load DB data into DataGrid
        /// </summary>
        private void LoadBookingDataGrid()
        {
            // Get opening time
            DateTime openingTime = context.Facilities
                .Where(x => x.FacilityType.Name == FacilityTypeComboBox.Text)
                .Min(x => x.OpeningTime).Value;

            // Get closing time
            DateTime closingTime = context.Facilities
                .Where(x => x.FacilityType.Name == FacilityTypeComboBox.Text)
                .Max(x => x.ClosingTime).Value;

            int noOfDays = (ToDateTimePicker.Value.AddHours(12) - FromDateTimePicker.Value).Days <= 0 ?
                1 : (ToDateTimePicker.Value - FromDateTimePicker.Value).Days + 2;

            int noOfSlots = (closingTime - openingTime).Hours;

            // Will default to 1 if calendar is selected wrongly.
            BookingDataGridView.ColumnCount = noOfDays;
            BookingDataGridView.RowCount = noOfSlots;

            foreach (DataGridViewColumn column in BookingDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Fill opening hours
            for (int i = 0; i < noOfSlots; i++)
            {
                BookingDataGridView.Rows[i].HeaderCell.Value =
                    $"{openingTime.Hour + i}:00 - {openingTime.AddHours(1).Hour + i}:00";
            }

            // Fill days
            for (int i = 0; i < noOfDays; i++)
            {
                BookingDataGridView.Columns[i].HeaderCell.Value =
                    FromDateTimePicker.Value.AddDays(i).ToShortDateString();
            }

            int totalFacilitiesOfType = context.Facilities
                .Count(x => x.FacilityType.Name == FacilityTypeComboBox.Text);

            // Fill Status
            for (int i = 0; i < noOfDays; i++)
            {
                for (int j = 0; j < noOfSlots; j++)
                {
                    int yearComparison = FromDateTimePicker.Value.AddDays(i).Year;
                    int monthComparison = FromDateTimePicker.Value.AddDays(i).Month;
                    int dayComparison = FromDateTimePicker.Value.AddDays(i).Day;

                    // Get List of Bookings that match FacilityName, FromDate, TimeSlot and are not cancelled
                    var list = context.Bookings
                        .Where(x => x.Facility.FacilityType.Name == FacilityTypeComboBox.Text &&
                            x.BookingDate.Value.Year == yearComparison &&
                            x.BookingDate.Value.Month == monthComparison &&
                            x.BookingDate.Value.Day == dayComparison &&
                            x.Status == 1 &&
                            x.Timeslot == j + 1)
                        .ToList();

                    if (list.Count == 0)
                    {
                        BookingDataGridView.Rows[j].Cells[i].Value = "Vacant";
                        BookingDataGridView.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(198, 239, 206);
                        BookingDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(0, 97, 0);
                    }
                    else if (list.Count < totalFacilitiesOfType)
                    {
                        BookingDataGridView.Rows[j].Cells[i].Value = "Filled";
                        BookingDataGridView.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(255, 235, 156);
                        BookingDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(156, 101, 0);
                    }
                    else
                    {
                        BookingDataGridView.Rows[j].Cells[i].Value = "Fully Booked";
                        BookingDataGridView.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(255, 199, 206);
                        BookingDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(156, 0, 6);
                    }
                }
            }
        }

        /// <summary>
        /// Load Facility Types from DB into the Facility Types combo box.
        /// </summary>
        private void LoadFacilityTypes()
        {
            var facilityTypes = context.FacilityTypes
                .Select(x => new { x.Name })
                .ToList();

            foreach (var facilityType in facilityTypes)
            {
                FacilityTypeComboBox.Items.Add(facilityType.Name.ToString());
            }
        }

        private void FacilityTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBookingDataGrid();
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FacilityTypeComboBox.Text != "")
            {
                LoadBookingDataGrid();
            }
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FacilityTypeComboBox.Text != "")
            {
                LoadBookingDataGrid();
            }
        }
    }
}
