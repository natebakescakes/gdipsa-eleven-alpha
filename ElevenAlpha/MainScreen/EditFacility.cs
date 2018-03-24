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
    public partial class EditFacility : Form
    {
        int facilityid=17;//take from Home page,after click edit
        string typename;
        int i = 0;
        DateTime opentime;
        DateTime closetime;

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

            //? how to show the time...
          
            CloseTimeMaskT.Text = f.ClosingTime.ToString();

            int openhour = f.OpeningTime.Value.Hour;
            int closehour = f.ClosingTime.Value.Hour;
            if (openhour < 10)
            { OpenTimeMaskT.Text = "0" + openhour.ToString()+"00"; }
            else
            {
                OpenTimeMaskT.Text = openhour.ToString()+"00";
            }

            if (closehour < 10)
            { CloseTimeMaskT.Text = "0" + closehour.ToString() + "00"; }
            else
            {
                CloseTimeMaskT.Text = closehour.ToString() + "00";
            }

            LocationTextB.Text = f.Location;
            DescriptionTextB.Text = f.Description;

        }




        private void FacilityTypeComB_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                typename = FacilityTypeComB.SelectedItem.ToString();

        }




        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            // faciliytid from another form
            Facility f = ctx.Facilities.Where(x => x.FacilityID == facilityid).FirstOrDefault();
            // the facility select

            int flag = 0;
            string inputname = FacilityNameTextB.Text;
            if (inputname == "")
            {
                MessageBox.Show("Pls input the facility name.");
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
                if (flag > 0 && inputname != f.Name)
                { MessageBox.Show("This Facility Name already exist.pls input another one."); flag = 0; }
                else
                {
                    f.Name = inputname;
                    if (OpenTimeMaskT.MaskedTextProvider.AssignedEditPositionCount == 0)
                    { MessageBox.Show("pls input opening time."); }
                    else
                    {
                        opentime = Convert.ToDateTime(OpenTimeMaskT.Text.ToString());

                        if (CloseTimeMaskT.MaskedTextProvider.AssignedEditPositionCount == 0)
                        { MessageBox.Show("pls input closing time."); }
                        else
                        {
                            closetime = Convert.ToDateTime(CloseTimeMaskT.Text.ToString());
                            f.Location = LocationTextB.Text;
                            f.Description = DescriptionTextB.Text;
                            f.Active = 1;
                            f.OpeningTime = opentime;
                            f.ClosingTime = closetime;
                            ctx.SaveChanges();
                            MessageBox.Show("Edit Facility successful!");

                        }
                    }

                }

            }
         }

    }
}
