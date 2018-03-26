using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevenAlpha
{
    public partial class FacilitiesTab : UserControl
    {
        private CreateFacility createfacilityform;
        
        public FacilitiesTab()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            createfacilityform = new CreateFacility();
            createfacilityform.facilitiesTab = this;

            //Data Grid Columns
            FacilitiesdataGridView1.ColumnCount = 6;
            for (int i = 0; i < FacilitiesdataGridView1.ColumnCount; i++)
            {
                string[] FacilityGridColumns = new string[] { "Facility ID", "Facility Name", "Facility Type", "Opening Hours", "No. of Slots", "Active" };
                FacilitiesdataGridView1.Columns[i].Name = FacilityGridColumns[i];
                FacilitiesdataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            LoadDataGridView();
        }
        //loads data 
        private void LoadDataGridView()
        {
            
            //filling columns
            FacilitiesdataGridView1.AutoGenerateColumns = false;
            ElevenAlphaEntities context = new ElevenAlphaEntities();

            var columns = context.Facilities
                .Select
                (x => new Result
                {
                    FacilityID = x.FacilityID,
                    Name = x.Name,
                    TypeID = (int)x.TypeID,
                    Active = (int)x.Active,
                    OpeningTime = (DateTime)x.OpeningTime,
                    ClosingTime = (DateTime)x.ClosingTime

                });

            var resultsList = columns.ToList();
            for (int i = 0; i < resultsList.Count; i++)
            {
                //Opening time to closing time
                var result = resultsList[i];
                var opening = (result.OpeningTime).ToString("H:mm");
                var closing = (result.ClosingTime).ToString("H:mm");
                result.Difference = opening + " - " + closing;

                //number of hours between opening and closing
                var start = (result.OpeningTime.TimeOfDay);
                var end = (result.ClosingTime.TimeOfDay);
                TimeSpan duration = end - start;
                result.HoursOpen = int.Parse(duration.TotalHours.ToString());

                //active status
                var activestatus = (result.Active.ToString());
                if (activestatus == "1")
                {
                    activestatus = "Active";
                }
                else
                {
                    activestatus = "Deactivated";
                }
                result.ActiveStatus = activestatus;
            }

            FacilitiesdataGridView1.Columns[0].DataPropertyName = "FacilityID";
            FacilitiesdataGridView1.Columns[1].DataPropertyName = "Name";
            FacilitiesdataGridView1.Columns[2].DataPropertyName = "TypeID";
            FacilitiesdataGridView1.Columns[3].DataPropertyName = "Difference";
            FacilitiesdataGridView1.Columns[4].DataPropertyName = "HoursOpen";
            FacilitiesdataGridView1.Columns[5].DataPropertyName = "ActiveStatus";
            FacilitiesdataGridView1.DataSource = resultsList;
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            LoadDataSearchFilter();
        }
        //loads data with search textbox filter
        public void LoadDataSearchFilter()
        {
            ElevenAlphaEntities context = new ElevenAlphaEntities();
            var searchValue = SearchTextbox.Text.Trim();
            var columns = context.Facilities
                .Where(x => x.Name.Contains(searchValue) || x.FacilityID.ToString().Contains(searchValue))
                .Select(x => new Result
                {
                    FacilityID = x.FacilityID,
                    Name = x.Name,
                    TypeID = (int)x.TypeID,
                    Active = (int)x.Active,
                    OpeningTime = (DateTime)x.OpeningTime,
                    ClosingTime = (DateTime)x.ClosingTime

                });

            var resultsList = columns.ToList();
            for (int i = 0; i < resultsList.Count; i++)
            {
                //Opening time to closing time
                var result = resultsList[i];
                var opening = (result.OpeningTime).ToString("H:mm");
                var closing = (result.ClosingTime).ToString("H:mm");
                result.Difference = opening + " - " + closing;

                //number of hours between opening and closing
                var start = (result.OpeningTime.TimeOfDay);
                var end = (result.ClosingTime.TimeOfDay);
                TimeSpan duration = end - start;
                result.HoursOpen = int.Parse(duration.TotalHours.ToString());

                //active status
                var activestatus = (result.Active.ToString());
                if (activestatus == "1")
                {
                    activestatus = "Active";
                }
                else
                {
                    activestatus = "Deactivated";
                }
                result.ActiveStatus = activestatus;
            }

            FacilitiesdataGridView1.Columns[0].DataPropertyName = "FacilityID";
            FacilitiesdataGridView1.Columns[1].DataPropertyName = "Name";
            FacilitiesdataGridView1.Columns[2].DataPropertyName = "TypeID";
            FacilitiesdataGridView1.Columns[3].DataPropertyName = "Difference";
            FacilitiesdataGridView1.Columns[4].DataPropertyName = "HoursOpen";
            FacilitiesdataGridView1.Columns[5].DataPropertyName = "ActiveStatus";
            FacilitiesdataGridView1.DataSource = resultsList;
        }

        //Cue for searchbox
        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            
        }
        //Hiding or showing deactivated facilities via checkbox
        private void ActiveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            StatusFilter();
        }

        public void StatusFilter()
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[FacilitiesdataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            for (int i = 0; i < FacilitiesdataGridView1.RowCount; i++)
            {
                if (FacilitiesdataGridView1.Rows[i].Cells[5].Value.ToString() == "Deactivated" && ActiveCheckbox.Checked)
                {
                    FacilitiesdataGridView1.Rows[i].Visible = false;
                }
                if (FacilitiesdataGridView1.Rows[i].Cells[5].Value.ToString() == "Deactivated" && !ActiveCheckbox.Checked)
                {
                    FacilitiesdataGridView1.Rows[i].Visible = true;
                }
            }
        }

        //Activating facilities
        private void FacilitiesTabBtnActivate_Click(object sender, EventArgs e)
        {
            ElevenAlphaEntities context = new ElevenAlphaEntities();
            int q = (int)FacilitiesdataGridView1.SelectedRows[0].Cells[0].Value;
            Facility toactive = context.Facilities.Where(x => x.FacilityID == q).First();

            if (toactive.Active == 1)
            {
                MessageBox.Show("Facility already activated");
            }
            else 
            {
                toactive.Active = 1;
                MessageBox.Show("Facility activated");
                context.SaveChanges();
                LoadDataSearchFilter();
                StatusFilter();
            }
            
        }
        //deactivating facilities
        private void FacilitiesTabBtnDeactivate_Click(object sender, EventArgs e)//already deactivated keeps popping out
        {
            ElevenAlphaEntities context = new ElevenAlphaEntities();
            int q = (int)FacilitiesdataGridView1.SelectedRows[0].Cells[0].Value;
            Facility toinactive = context.Facilities.Where(x => x.FacilityID == q).First();
            
            if (toinactive.Active == 0)
            {
                MessageBox.Show("Facility already deactivated");
            }
            else
            {
                toinactive.Active = 0;
                MessageBox.Show("Facility deactivated");
                context.SaveChanges();
                LoadDataSearchFilter();
                StatusFilter();
            }
        }

        private void FacilititesTabBtnNew_Click(object sender, EventArgs e)
        {
            CreateFacility f2 = new CreateFacility();
            f2.ShowDialog();

            if (f2.DialogResult == DialogResult.OK)
            {
                //refresh();
                LoadDataSearchFilter();
                StatusFilter();
            }
        }

        private void FacilitiesTabBtnEdit_Click(object sender, EventArgs e)
        {
            int facilityid =(int) FacilitiesdataGridView1.SelectedRows[0].Cells[0].Value;
            EditFacility ftm = new EditFacility(facilityid );
           
            ftm.ShowDialog();
           
            if(ftm.DialogResult==DialogResult.OK)
                {
                //refresh();
                LoadDataSearchFilter();
                StatusFilter();
            }
        }
    }
    public class Result
    {
        public int FacilityID { get; set; }
        public string Name { get; set; }
        public int TypeID { get; set; }
        public int Active { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public string Difference { get; set; }
        public double HoursOpen { get; set; }
        public string ActiveStatus { get; set; }
         
    }
}

