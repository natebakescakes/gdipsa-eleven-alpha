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
        public FacilityTypeManager()
        {
            InitializeComponent();
        }

        

        private void FacilityTypeManager_Load(object sender, EventArgs e)
        {
            ElevenAlphaEntities ctx = new ElevenAlphaEntities();
         
            var q = from x in ctx.FacilityTypes where x.Active == 1 select
                    new { x .Name};

            FacilityDataGrid.DataSource = q.ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            ElevenAlphaEntities ctx1 = new ElevenAlphaEntities();
            FacilityType f = new FacilityType();
            f.Name = InputTypeNameTextBox.Text;
            f.Active = 1;
            ctx1.FacilityTypes.Add(f);
            ctx1.SaveChanges();

            //refresh
            ElevenAlphaEntities ctx = new ElevenAlphaEntities();

            var q = from x in ctx.FacilityTypes
                    where x.Active == 1
                    select new { x.Name };

            FacilityDataGrid.DataSource = q.ToList();


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

           string OldType = FacilityDataGrid.SelectedCells[0].Value.ToString();

            ElevenAlphaEntities ctx1 = new ElevenAlphaEntities();

            FacilityType f1 = ctx1.FacilityTypes.Where(x => x.Name == OldType).First();
            f1.Name = InputTypeNameTextBox.Text;         
            ctx1.SaveChanges();

            // refresh datagridview
            ElevenAlphaEntities ctx = new ElevenAlphaEntities();

            var q = from x in ctx.FacilityTypes
                    where x.Active == 1
                    select new { x.Name };

            FacilityDataGrid.DataSource = q.ToList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            string OldType = FacilityDataGrid.SelectedCells[0].Value.ToString();

            ElevenAlphaEntities ctx1 = new ElevenAlphaEntities();

            FacilityType f1 = ctx1.FacilityTypes.Where(x => x.Name == OldType).First();
            ctx1.FacilityTypes.Remove(f1);
            ctx1.SaveChanges();


            // refresh datagridview
            ElevenAlphaEntities ctx = new ElevenAlphaEntities();

            var q = from x in ctx.FacilityTypes
                    where x.Active == 1
                    select new { x.Name };

            FacilityDataGrid.DataSource = q.ToList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
