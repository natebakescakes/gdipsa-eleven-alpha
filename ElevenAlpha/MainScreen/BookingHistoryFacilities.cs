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
    public partial class BookingHistoryFacilities : Form
    {
        ElevenAlphaEntities context;

        public BookingHistoryFacilities(int facilityId, DateTime fromDateTime, DateTime toDateTime)
        {
            InitializeComponent();
            context = new ElevenAlphaEntities();

            FacilityIdTextBox.Text = facilityId.ToString();

            LoadBookingHistoryDataGrid();
        }

        private void LoadBookingHistoryDataGrid()
        {
            int facilityId = -1;

            if (FacilityIdTextBox.Text != "" && !Int32.TryParse(FacilityIdTextBox.Text, out facilityId))
            {
                MessageBox.Show("Invalid Facility ID.");
                return;
            }

            if (ShowCancelledCheckBox.Checked)
            {
                BookingFacilityDataGrid.DataSource = context.Bookings
                    .Where(x => x.FacilityID == facilityId &&
                        x.BookingDate.Value >= FromDateTimePicker.Value &&
                        x.BookingDate.Value <= ToDateTimePicker.Value && 
                        (x.MemberID.Value.ToString().Contains(SearchTextBox.Text) || 
                        x.Member.FirstName.Contains(SearchTextBox.Text) ||
                        x.Member.LastName.Contains(SearchTextBox.Text)))
                    .Select(x => new
                    {
                        x.BookingID,
                        x.DateRequested,
                        x.BookingDate,
                        x.Timeslot,
                        x.MemberID,
                        x.Member.FirstName,
                        x.Member.LastName,
                        Status = x.Status == 1 ? "Booked" : "Cancelled"
                    })
                    .ToList();
            }
            else
            {
                BookingFacilityDataGrid.DataSource = context.Bookings
                    .Where(x => x.FacilityID == facilityId &&
                        x.BookingDate.Value >= FromDateTimePicker.Value &&
                        x.BookingDate.Value <= ToDateTimePicker.Value &&
                        x.Status == 1 &&
                        (x.MemberID.Value.ToString().Contains(SearchTextBox.Text) ||
                        x.Member.FirstName.Contains(SearchTextBox.Text) ||
                        x.Member.LastName.Contains(SearchTextBox.Text)))
                    .Select(x => new
                    {
                        x.BookingID,
                        x.DateRequested,
                        x.BookingDate,
                        x.Timeslot,
                        x.MemberID,
                        x.Member.FirstName,
                        x.Member.LastName,
                        Status = x.Status == 1 ? "Booked" : "Cancelled"
                    })
                    .ToList();
            }
        }

        private void FacilityIdTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }
    }
}
