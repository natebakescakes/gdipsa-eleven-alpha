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

        public MainScreen()
        {
            InitializeComponent();
            bookingTab = new BookingTab();
            bookingsTabPage.Controls.Add(bookingTab);
        }
    }
}
