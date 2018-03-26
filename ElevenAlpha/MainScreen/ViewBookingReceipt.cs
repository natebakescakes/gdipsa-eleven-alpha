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
    public partial class ViewBookingReceipt : Form
    {
        private ElevenAlphaEntities context;
        private int bookingId;

        public ViewBookingReceipt(int bookingId)
        {
            InitializeComponent();

            context = new ElevenAlphaEntities();
            this.bookingId = bookingId;
        }

        private void ViewBookingReceipt_Load(object sender, EventArgs e)
        {
            BookingReceipt bookingReceipt = new BookingReceipt();

            bookingReceipt.Database.Tables[0].SetDataSource(context.Bookings
                .Where(x => x.BookingID == bookingId)
                .Select(x => new
                {
                    x.BookingID,
                    FacilityID = x.FacilityID ?? 0,
                    MemberID = x.MemberID ?? 0,
                    BookingDate = x.BookingDate ?? new DateTime(),
                    Timeslot = x.Timeslot ?? 0,
                    DateRequested = x.DateRequested ?? new DateTime(),
                    Status = x.Status == 1 ? "Booked" : "Cancelled"
                }));

            bookingReceipt.Database.Tables[1].SetDataSource(context.Members
                .Where(x => x.MemberID == context.Bookings.Where(y => y.BookingID == bookingId).FirstOrDefault().MemberID)
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName
                }));

            bookingReceipt.Database.Tables[2].SetDataSource(context.Facilities
                .Where(x => x.FacilityID == context.Bookings.Where(y => y.BookingID == bookingId).FirstOrDefault().FacilityID)
                .Select(x => new
                {
                    x.Name,
                    OpeningTime = x.OpeningTime ?? new DateTime()
                }));

            crystalReportViewer1.ReportSource = bookingReceipt;
        }
    }
}
