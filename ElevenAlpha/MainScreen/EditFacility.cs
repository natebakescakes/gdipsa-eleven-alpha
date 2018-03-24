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
    public partial class EditFacility : Form
    {
        int facilityid=17;//take from Home page,after click edit
        int i = 0;
        ElevenAlphaEntities ctx = new ElevenAlphaEntities();
        public EditFacility()
        {
            InitializeComponent();
        }

        private void EditFacility_Load(object sender, EventArgs e)
        {
            Facility f = ctx.Facilities.Where(x => x.FacilityID == facilityid).FirstOrDefault();

            // take facilityname and typename from
            FacilityNameTextB.Text = f.Name;
            string facilityType=f.FacilityType.ToString();

            int n = 0;
                foreach (FacilityType ft in ctx.FacilityTypes)
                {             
                FacilityTypeComB.Items.Add(ft.Name);               
                if (f.TypeID== ft.TypeID)
                {  i = n; }
                n++;
            }
            FacilityTypeComB.SelectedIndex = i;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
