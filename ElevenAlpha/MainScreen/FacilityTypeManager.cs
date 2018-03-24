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
    public partial class FacilityTypeManager : Form
    {
        ElevenAlphaEntities ctx= new ElevenAlphaEntities();

        public void refresh()
        {
            var q = from x in ctx.FacilityTypes
                    where x.Active == 1
                    select new { x.Name };

            FacilityDataGrid.DataSource = q.ToList();

        }


        public FacilityTypeManager()
        {
            InitializeComponent();
        }
        private void FacilityTypeManager_Load(object sender, EventArgs e)
        {

            refresh();

        
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            ElevenAlphaEntities ctx = new ElevenAlphaEntities();
            FacilityType f = new FacilityType();
            f.Name = InputTypeNameTextBox.Text;
            f.Active = 1;
            ctx.FacilityTypes.Add(f);
            ctx.SaveChanges();

            refresh();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

           string OldType = FacilityDataGrid.SelectedCells[0].Value.ToString();
          FacilityType f1 = ctx.FacilityTypes.Where(x => x.Name == OldType).FirstOrDefault(); //
            f1.Name = InputTypeNameTextBox.Text;         
            ctx.SaveChanges();

            refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //check whether related type has related record

            string OldType = FacilityDataGrid.SelectedCells[0].Value.ToString();//selected typename

            FacilityType ft = ctx.FacilityTypes.Where(x => x.Name == OldType).First();//selected facilityType
            List<int> fi=new List<int>(); //typeid related facilityid Array
            foreach (Facility f in ctx.Facilities)
            {
                if (f.TypeID == ft.TypeID)

                {
                    fi.Add(f.FacilityID);
                }
             }
            int flag = 0;
      
          foreach(Booking b in ctx.Bookings )
            {
                for(int i=0;i<fi.Count();i++)
                {
                    if (b.FacilityID == fi[i])
                    flag++;
                        
                }
            }
            if (flag != 0)
            {
                MessageBox.Show("can't delete due to there are booking records");
                flag = 0;
            }
            else
            {
                FacilityType f = ctx.FacilityTypes.Where(x => x.Name == OldType).First();
                ctx.FacilityTypes.Remove(f);
                ctx.SaveChanges();
            }
            refresh();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
