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
        members_tab membersUserControl;

        FacilitiesTab facilitiestab;
        public MainScreen()
        {
            InitializeComponent();
            
            // Initialize Bookings Tab
            bookingTab = new BookingTab();
            bookingsTabPage.Controls.Add(bookingTab);
            
            // Initialize Members Tab
            membersUserControl = new members_tab();
            membersTabPage.Controls.Add(membersUserControl);
        }

        
    }
}
