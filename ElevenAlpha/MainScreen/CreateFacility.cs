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
    public partial class CreateFacility : Form
    {
        ElevenAlphaEntities ctx = new ElevenAlphaEntities();
        string typename = "";

        public CreateFacility()
        {
            InitializeComponent();
           
        }

      
        public void CreatFacility_Load(object sender, EventArgs e)
        {

            refresh();

        }

        private void refresh()
        {
            FacilityTypeComB.Items.Clear();

            foreach (FacilityType ft in ctx.FacilityTypes)

            { FacilityTypeComB.Items.Add(ft.Name); }

            FacilityTypeComB.Items.Add("New...");
        }

       

        private void FacilityTypeComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FacilityTypeComB.SelectedItem.ToString() == "New...")
            {
                FacilityTypeManager ftm = new FacilityTypeManager(this);
                ftm.Show();

            }
            else
            {
                typename = FacilityTypeComB.SelectedItem.ToString();

            }

        }

        private void AddFacilityButton_Click(object sender, EventArgs e)
        {
            Facility f = new Facility();
            f.Name = FacilityNameTxtB.Text;//setacility name

            FacilityType ft = ctx.FacilityTypes.Where(x => x.Name == typename).FirstOrDefault(); //found selected facilitytype
            f.TypeID = ft.TypeID; // set facility typeid 

            f.OpeningTime = Convert.ToDateTime(OpenHrsMskTxB.Text);
            f.ClosingTime = Convert.ToDateTime(CloseHrsTexB.Text);

            f.Location = LocationTexB.Text;
            f.Description = DescriptionTexB.Text;
            f.Active = 1;

            ctx.Facilities.Add(f);
            ctx.SaveChanges();
        }

       

       

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
