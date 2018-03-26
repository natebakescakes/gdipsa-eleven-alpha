namespace ElevenAlpha
{
    partial class ViewOccupancyTrend
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
            this.OccupancyTrendReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // OccupancyTrendReport
            // 
            this.OccupancyTrendReport.ActiveViewIndex = -1;
            this.OccupancyTrendReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OccupancyTrendReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.OccupancyTrendReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OccupancyTrendReport.Location = new System.Drawing.Point(0, 0);
            this.OccupancyTrendReport.Name = "OccupancyTrendReport";
            this.OccupancyTrendReport.Size = new System.Drawing.Size(800, 450);
            this.OccupancyTrendReport.TabIndex = 0;
            this.OccupancyTrendReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ViewOccupancyTrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OccupancyTrendReport);
            this.Name = "ViewOccupancyTrend";
            this.Text = "View Occupancy Trend";
            this.Load += new System.EventHandler(this.ViewOccupancyTrend_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer OccupancyTrendReport;
    }
}