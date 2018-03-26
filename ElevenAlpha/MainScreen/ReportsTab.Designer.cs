namespace ElevenAlpha
{
    partial class ReportsTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OccupancyRateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OccupancyRateButton
            // 
            this.OccupancyRateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OccupancyRateButton.Location = new System.Drawing.Point(147, 275);
            this.OccupancyRateButton.Name = "OccupancyRateButton";
            this.OccupancyRateButton.Size = new System.Drawing.Size(980, 99);
            this.OccupancyRateButton.TabIndex = 0;
            this.OccupancyRateButton.Text = "View Occupancy Rates (All-time)";
            this.OccupancyRateButton.UseVisualStyleBackColor = true;
            this.OccupancyRateButton.Click += new System.EventHandler(this.OccupancyRateButton_Click);
            // 
            // ReportsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OccupancyRateButton);
            this.Name = "ReportsTab";
            this.Size = new System.Drawing.Size(1271, 742);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OccupancyRateButton;
    }
}
