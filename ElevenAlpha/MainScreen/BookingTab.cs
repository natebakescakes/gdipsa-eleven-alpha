using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevenAlpha
{
    public partial class BookingTab : UserControl
    {
        ElevenAlphaEntities context;

        public BookingTab()
        {
            InitializeComponent();
            context = new ElevenAlphaEntities();
            LoadFacilityTypes();
            LoadBookingDataGrid();
        }

        /// <summary>
        /// Load DB data into DataGrid
        /// </summary>
        private void LoadBookingDataGrid()
        {
            // Get opening time
            //DateTime openingTime = context.Facilities
            //    .Where(x => x.FacilityType.Name == facilityTypeComboBox.Text)
            //    .Min(x => x.OpeningTime).Value;
        }

        /// <summary>
        /// Load Facility Types from DB into the Facility Types combo box.
        /// </summary>
        private void LoadFacilityTypes()
        {
            var facilityTypes = context.FacilityTypes.Select(x => new { x.Name }).ToList();
            foreach (var facilityType in facilityTypes)
            {
                facilityTypeComboBox.Items.Add(facilityType.Name.ToString());
            }
        }

        private void facilityTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBookingDataGrid();
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingDataGrid();
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBookingDataGrid();
        }
    }
}
