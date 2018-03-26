namespace ElevenAlpha
{
    partial class ViewBookingReceipt
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
            this.BookingReceiptCrystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BookingReceiptCrystalReport
            // 
            this.BookingReceiptCrystalReport.ActiveViewIndex = -1;
            this.BookingReceiptCrystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookingReceiptCrystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.BookingReceiptCrystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingReceiptCrystalReport.Location = new System.Drawing.Point(0, 0);
            this.BookingReceiptCrystalReport.Name = "BookingReceiptCrystalReport";
            this.BookingReceiptCrystalReport.Size = new System.Drawing.Size(1221, 1412);
            this.BookingReceiptCrystalReport.TabIndex = 0;
            this.BookingReceiptCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ViewBookingReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 1412);
            this.Controls.Add(this.BookingReceiptCrystalReport);
            this.Name = "ViewBookingReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBookingReceipt";
            this.Load += new System.EventHandler(this.ViewBookingReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BookingReceiptCrystalReport;
    }
}