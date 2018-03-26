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
        public BookingTab bookingTab;
        public MembersTab membersUserControl;
        public FacilitiesTab facilitiesTab;
       
        public MainScreen()
        {
            InitializeComponent();
            
            // Initialize Bookings Tab
            bookingTab = new BookingTab(this);
            bookingsTabPage.Controls.Add(bookingTab);
            
            // Initialize Members Tab
            membersUserControl = new MembersTab();
            membersTabPage.Controls.Add(membersUserControl);

            // Initialize Facilities Tab
            facilitiesTab = new FacilitiesTab(this);
            facilitiesTabPage.Controls.Add(facilitiesTab);
        }
    }
}
