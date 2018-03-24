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
        FacilitiesTab facilitiestab;
        public MainScreen()
        {
            InitializeComponent();

            facilitiestab = new FacilitiesTab();
            facilitiesTabPage.Controls.Add(facilitiestab);
          
        }

        
    }
}
