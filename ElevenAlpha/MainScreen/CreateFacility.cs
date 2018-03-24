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
                ftm.ShowDialog();

            }
            else
            {
                typename = FacilityTypeComB.SelectedItem.ToString();

            }

        }






        private void AddFacilityButton_Click(object sender, EventArgs e)
        {
            Facility f = new Facility();
            int flag = 0;
            DateTime opentime;
            DateTime closetime;

            string inputname = FacilityNameTxtB.Text;
            if (inputname == "")
            {
                MessageBox.Show("Please input the Facility Name.");
            }

            else
            {
                foreach (Facility f1 in ctx.Facilities)
                {
                    if (f1.Name == inputname)
                    {
                        flag++; break;

                    }
                }
                if (flag > 0)
                { MessageBox.Show("This Facility Name already exists. Please input a different one."); flag = 0; }
                else
                {
                    f.Name = inputname;

                    if (typename == "")
                    {
                        MessageBox.Show("Please choose a Facility Type.");

                    }
                    else
                    {
                        FacilityType ft = ctx.FacilityTypes.Where(x => x.Name == typename).FirstOrDefault(); //found selected facilitytype
                        f.TypeID = ft.TypeID; // set facility typeid 

                        if (OpenHrsMskTxB.MaskedTextProvider.AssignedEditPositionCount == 0)
                        { MessageBox.Show("Please input the Opening Time."); }
                        else
                        {
                            opentime = Convert.ToDateTime(OpenHrsMskTxB.Text.ToString());

                            if (CloseHrsMskTxB.MaskedTextProvider.AssignedEditPositionCount == 0)
                            { MessageBox.Show("Please input the Closing Time."); }
                            else
                            {
                                closetime = Convert.ToDateTime(CloseHrsMskTxB.Text.ToString());

                                f.Location = LocationTexB.Text;
                                f.Description = DescriptionTexB.Text;
                                f.Active = 1;


                                ctx.Facilities.Add(f);
                                ctx.SaveChanges();
                                MessageBox.Show("Successfully added Facility.");
                            }
                        }
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

