namespace ElevenAlpha
{
    partial class ViewOccupancyRates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OccupancyRatesReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // OccupancyRatesReport
            // 
            this.OccupancyRatesReport.ActiveViewIndex = -1;
            this.OccupancyRatesReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OccupancyRatesReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.OccupancyRatesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OccupancyRatesReport.Location = new System.Drawing.Point(0, 0);
            this.OccupancyRatesReport.Name = "OccupancyRatesReport";
            this.OccupancyRatesReport.Size = new System.Drawing.Size(800, 450);
            this.OccupancyRatesReport.TabIndex = 0;
            this.OccupancyRatesReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ViewOccupancyRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OccupancyRatesReport);
            this.Name = "ViewOccupancyRates";
            this.Text = "View Occupancy Rates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewOccupancyRates_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer OccupancyRatesReport;
    }
}