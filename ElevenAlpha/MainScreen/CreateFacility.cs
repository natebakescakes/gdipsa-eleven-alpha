﻿using System;
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

            RefreshFacilityTypes();

        }

        private void RefreshFacilityTypes()
        {
            FacilityTypeComB.Items.Clear();

            foreach (FacilityType ft in ctx.FacilityTypes)
             if(ft.Active==1)
            { FacilityTypeComB.Items.Add(ft.Name);}

            FacilityTypeComB.Items.Add("Manage Facility Types...");
        }



        private void FacilityTypeComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FacilityTypeComB.SelectedItem.ToString() == "Manage Facility Types...")
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
                    if (f1.Name.ToLower() == inputname.ToLower())
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
                        else if (Convert.ToDateTime(OpenHrsMskTxB.Text.ToString())>= Convert.ToDateTime(CloseHrsMskTxB.Text.ToString()))
                        {MessageBox.Show("Please input a closing time later than opening time!");}
                        
                        else
                        {
                            DateTime d1 = Convert.ToDateTime(OpenHrsMskTxB.Text.ToString());
                            
                            
                            //OpenHrsMskTxB.value.hour
                            opentime = new DateTime(1900,1,1,d1.Hour,d1.Minute,d1.Second);//

                            if (CloseHrsMskTxB.MaskedTextProvider.AssignedEditPositionCount == 0)
                            { MessageBox.Show("Please input the Closing Time."); }
                            else
                            {
                                DateTime d2 = Convert.ToDateTime(CloseHrsMskTxB.Text.ToString());

                                closetime = new DateTime(1900,01,01,d2.Hour,d2.Minute,d2.Second);//

                                f.Location = LocationTexB.Text;
                                f.Description = DescriptionTexB.Text;
                                f.Active = 1;
                                f.OpeningTime = opentime;
                                f.ClosingTime = closetime;
                                

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

