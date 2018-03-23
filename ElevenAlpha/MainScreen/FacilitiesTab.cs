using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class FacilitiesTab : UserControl
    {
        public FacilitiesTab()
        {
            InitializeComponent();
        }

        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search...")
            {
                SearchTextbox.Text = "";
                SearchTextbox.ForeColor = Color.Black;
            }
        }

        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "")
            {
                SearchTextbox.Text = "Search...";
                SearchTextbox.ForeColor = Color.Silver;
            }
        }
    }
}
