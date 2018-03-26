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
    public partial class ViewOccupancyRates : Form
    {
        ElevenAlphaEntities context;

        public ViewOccupancyRates()
        {
            InitializeComponent();
            context = new ElevenAlphaEntities();
        }

        private void ViewOccupancyRates_Load(object sender, EventArgs e)
        {
            var report = new OccupancyRates();
            OccupancyRatesReport.ReportSource = report;
        }
    }
}
