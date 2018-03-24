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
        public FacilitiesTab()
        {
            InitializeComponent();
            //Data Grid Columns
            dataGridView1.ColumnCount = 6;
            for (int i = 0; i<dataGridView1.ColumnCount;i++)
            {
                string[] FacilityGridColumns = new string[] { "Facility ID", "Facility Name","Facility Type", "Opening Hours", "No. of Slots", "Active" };
                dataGridView1.Columns[i].Name = FacilityGridColumns[i];
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //filling columns
            dataGridView1.AutoGenerateColumns = false;
            ElevenAlphaEntities context = new ElevenAlphaEntities();
            var columns = context.Facilities.Select
                (x => new Result{ FacilityID= x.FacilityID, Name = x.Name,
                TypeID = (int)x.TypeID, Active = (int)x.Active,
                OpeningTime = (DateTime)x.OpeningTime, ClosingTime = (DateTime)x.ClosingTime
                

             });

            var resultsList = columns.ToList();
            for (int i=0; i< resultsList.Count; i++)
            {
                var result = resultsList[i];
                var opening = (result.OpeningTime).ToString("H:mm");
                var closing = (result.ClosingTime).ToString("H:mm");
                result.Difference = opening + " - " + closing;

                var start = (result.OpeningTime.TimeOfDay);
                var end = (result.ClosingTime.TimeOfDay);
                TimeSpan duration = end - start;
                result.HoursOpen = int.Parse(duration.TotalHours.ToString());
               
            }

            dataGridView1.Columns[0].DataPropertyName = "FacilityID";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.Columns[2].DataPropertyName = "TypeID";
            dataGridView1.Columns[3].DataPropertyName = "Difference";
            dataGridView1.Columns[4].DataPropertyName = "HoursOpen";
            dataGridView1.Columns[5].DataPropertyName = "Active";
            dataGridView1.DataSource = resultsList;


        }
        private string getDifference(DateTime start, DateTime end)
        {
            return "hi";
            //return start.ToString().Substring(start.ToString().IndexOf("1900") + 6) + " to " + end.ToString().Substring(end.ToString().IndexOf("1900") + 6);
        }

        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search...")
            {
                SearchTextbox.Text = "";
                SearchTextbox.ForeColor = Color.Black;
            }
        }
        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "")
            {
                SearchTextbox.Text = "Search...";
                SearchTextbox.ForeColor = Color.Silver;
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
         
    }
}

