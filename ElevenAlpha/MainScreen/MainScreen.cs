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
    
    public partial class MainScreen : Form
    {
        BookingTab bookingTab;
        MembersTab membersUserControl;
        FacilitiesTab facilitiesTab;
        ReportsTab reportsTab;

        public MainScreen()
        {
            InitializeComponent();
            
            // Initialize Bookings Tab
            bookingTab = new BookingTab();
            bookingsTabPage.Controls.Add(bookingTab);
            
            // Initialize Members Tab
            membersUserControl = new MembersTab();
            membersTabPage.Controls.Add(membersUserControl);

            // Initialize Facilities Tab
            facilitiesTab = new FacilitiesTab();
            facilitiesTabPage.Controls.Add(facilitiesTab);

            // Initialize Reports Tab
            reportsTab = new ReportsTab();
            reportsTabPage.Controls.Add(reportsTab);
        }
    }
}
