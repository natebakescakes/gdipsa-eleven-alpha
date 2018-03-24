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
        ElevenAlphaEntities ctx;
        CreateFacility parent;


        public void refresh()
        {
            var q = from x in ctx.FacilityTypes
                    where x.Active == 1
                    select new { x.Name };

            FacilityDataGrid.DataSource = q.ToList();

        }


        public FacilityTypeManager(CreateFacility parent)
        {
            InitializeComponent();
            ctx = new ElevenAlphaEntities();
            this.parent = parent;
        }
        private void FacilityTypeManager_Load(object sender, EventArgs e)
        {

            refresh();
           


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string inputname = InputTypeNameTextBox.Text;
          
                 
            // check if the inputname already exist but deactive
            int flag = 0;
            foreach(FacilityType f1 in ctx.FacilityTypes )
            {
                if (f1.Name == inputname)
                {
                    ElevenAlphaEntities ctx = new ElevenAlphaEntities();
                    FacilityType f = ctx.FacilityTypes.Where(x => x.Name == inputname).First();
                    f.Active = 1;
                    flag = 1;
                    ctx.SaveChanges();
                    refresh();
                    break;
                }

            }

            if (flag == 0)
            {
                ElevenAlphaEntities ctx = new ElevenAlphaEntities();
                FacilityType fnew = new FacilityType();
                fnew.Active = 1;
                fnew.Name = inputname;
                ctx.FacilityTypes.Add(fnew);
                ctx.SaveChanges();
            }
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

        private void DeleteButton_Click(object sender, EventArgs e) //delete means Deactive
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
                ElevenAlphaEntities ctx = new ElevenAlphaEntities();
                OldType = FacilityDataGrid.SelectedCells[0].Value.ToString();
                FacilityType f = ctx.FacilityTypes.Where(x => x.Name == OldType).First();
                f.Active = 0; 
                ctx.SaveChanges();             
                refresh();
                
            }
           
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.CreatFacility_Load(parent, new EventArgs());

            
        }

        private void selectchanged(object sender, EventArgs e)
        {
           // InputTypeNameTextBox.Text= FacilityDataGrid.SelectedCells[0].Value.ToString();//selected typename
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            InputTypeNameTextBox.Text = FacilityDataGrid.SelectedCells[0].Value.ToString();//selected typename

        }
    }
}
