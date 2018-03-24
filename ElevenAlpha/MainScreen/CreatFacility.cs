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
    public partial class CreatFacility : Form
    {

       
        public CreatFacility()
        {
            InitializeComponent();
            ElevenAlphaEntities ctx = new ElevenAlphaEntities();
        }

       

        private void CreatFacility_Load(object sender, EventArgs e)
        {
            


            FacilityTypeComB.Items.Add("");
        }
    }
}
