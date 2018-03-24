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
        members_tab membersUserControl;

        FacilitiesTab facilitiestab;
        public MainScreen()
        {
            InitializeComponent();
            membersUserControl = new members_tab();
            membersTabPage.Controls.Add(membersUserControl);

   
        }

        private void membersTabPage_Click(object sender, EventArgs e)
        {


            facilitiestab = new FacilitiesTab();
            facilitiesTabPage.Controls.Add(facilitiestab);
          
        }

        
    }
}
