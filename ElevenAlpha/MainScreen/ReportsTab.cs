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
    public partial class ReportsTab : UserControl
    {
        public ReportsTab()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void OccupancyRateButton_Click(object sender, EventArgs e)
        {
            var occupancyRate = new ViewOccupancyRates();
            occupancyRate.ShowDialog();
        }

        private void OccupancyTrendButton_Click(object sender, EventArgs e)
        {
            var occupancyTrend = new ViewOccupancyTrend();
            occupancyTrend.ShowDialog();
        }
    }
}
