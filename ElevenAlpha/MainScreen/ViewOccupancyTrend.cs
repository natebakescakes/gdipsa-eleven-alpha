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
    public partial class ViewOccupancyTrend : Form
    {
        ElevenAlphaEntities context;

        public ViewOccupancyTrend()
        {
            InitializeComponent();
            context = new ElevenAlphaEntities();
        }

        private void ViewOccupancyTrend_Load(object sender, EventArgs e)
        {
            var report = new OccupancyTrend();
            OccupancyTrendReport.ReportSource = report;
        }
    }
}
