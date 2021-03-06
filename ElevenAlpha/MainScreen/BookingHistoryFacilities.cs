﻿using System;
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
        private int facilityId;

        public BookingHistoryFacilities(int facilityId, DateTime fromDateTime, DateTime toDateTime)
        {
            InitializeComponent();
            context = new ElevenAlphaEntities();

            FacilityIdTextBox.Text = facilityId.ToString();
            this.facilityId = facilityId;

            // Initialize DatePickers
            FromDateTimePicker.Value = fromDateTime;
            ToDateTimePicker.Value = toDateTime;

            // Load DataGrid
            LoadBookingHistoryDataGrid();

            // Initialize watermark
            FacilityNameTextBox_TextChanged(FacilityNameTextBox, new EventArgs());
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
                        x.Member.LastName.Contains(SearchTextBox.Text) ||
                        x.BookingID.ToString().Contains(SearchTextBox.Text)))
                    .OrderByDescending(x => x.BookingDate)
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
                        x.Member.LastName.Contains(SearchTextBox.Text) ||
                        x.BookingID.ToString().Contains(SearchTextBox.Text)))
                    .OrderByDescending(x => x.BookingDate)
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

            foreach (DataGridViewColumn column in BookingFacilityDataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void FacilityIdTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();

            if (FacilityIdTextBox.Text == "") { }
            else if (Int32.TryParse(FacilityIdTextBox.Text, out facilityId))
            {
                if (context.Facilities.Where(x => x.FacilityID == facilityId).FirstOrDefault() is null)
                    FacilityNameTextBox.Text = "";
                else
                    FacilityNameTextBox.Text = context.Facilities.Where(x => x.FacilityID == facilityId).First().Name;

            }
            else
            {
                MessageBox.Show("You have entered an invalid Facility ID.");
                FacilityNameTextBox.Text = "";
            }
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();

            ToDateTimePicker.MinDate = FromDateTimePicker.Value;
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void ViewReceiptButton_Click(object sender, EventArgs e)
        {
            if (BookingFacilityDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Booking Transaction to View Receipt.");
                return;
            }

            var bookingReceipt = new ViewBookingReceipt(Int32.Parse(BookingFacilityDataGrid.SelectedCells[0].Value.ToString()));
            bookingReceipt.ShowDialog();
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            if (BookingFacilityDataGrid.SelectedCells[7].Value.ToString() == "Cancelled")
            {
                MessageBox.Show("Booking has already been cancelled.");
                return;
            }

            DateTime selectedDate = (DateTime)BookingFacilityDataGrid.SelectedCells[2].Value;
            DateTime compareDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 0, 0, 0);

            if (compareDate.CompareTo(System.DateTime.Now) == -1)
            {
                MessageBox.Show("Cannot cancel past booking.");
                return;
            }

            int bookingId = Int32.Parse(BookingFacilityDataGrid.SelectedCells[0].Value.ToString());
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

        private void ShowCancelledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadBookingHistoryDataGrid();
        }

        private void FacilityNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FacilityNameTextBox.Text.Length == 0)
            {
                FacilityNameTextBox.BackColor = SystemColors.Control;
                FacilityNameTextBox.ForeColor = SystemColors.GrayText;
                //FirstNameTextBox.Font = new Font(FirstNameTextBox.Font, FontStyle.Italic);
                FacilityNameTextBox.Text = "Facility Name";
            }
            else if (FacilityNameTextBox.Text != "Facility Name")
            {
                FacilityNameTextBox.BackColor = SystemColors.Control;
                FacilityNameTextBox.ForeColor = SystemColors.ControlText;
                //FirstNameTextBox.Font = new Font(FirstNameTextBox.Font, FirstNameTextBox.Font.Style & ~FontStyle.Italic);
            }
        }
    }
}
