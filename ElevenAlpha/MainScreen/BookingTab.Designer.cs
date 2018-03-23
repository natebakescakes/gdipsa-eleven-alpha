namespace MainScreen
{
    partial class BookingTab
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
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.facilityTypeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tildeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingDataGridView.Location = new System.Drawing.Point(0, 75);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.RowTemplate.Height = 40;
            this.bookingDataGridView.Size = new System.Drawing.Size(1561, 837);
            this.bookingDataGridView.TabIndex = 0;
            // 
            // facilityTypeLabel
            // 
            this.facilityTypeLabel.AutoSize = true;
            this.facilityTypeLabel.Location = new System.Drawing.Point(26, 21);
            this.facilityTypeLabel.Name = "facilityTypeLabel";
            this.facilityTypeLabel.Size = new System.Drawing.Size(175, 32);
            this.facilityTypeLabel.TabIndex = 1;
            this.facilityTypeLabel.Text = "Facility Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 39);
            this.comboBox1.TabIndex = 2;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(1097, 19);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 38);
            this.fromDateTimePicker.TabIndex = 3;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(1340, 21);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 38);
            this.toDateTimePicker.TabIndex = 4;
            // 
            // tildeLabel
            // 
            this.tildeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tildeLabel.AutoSize = true;
            this.tildeLabel.Location = new System.Drawing.Point(1303, 32);
            this.tildeLabel.Name = "tildeLabel";
            this.tildeLabel.Size = new System.Drawing.Size(31, 32);
            this.tildeLabel.TabIndex = 5;
            this.tildeLabel.Text = "~";
            // 
            // BookingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tildeLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.facilityTypeLabel);
            this.Controls.Add(this.bookingDataGridView);
            this.Name = "BookingTab";
            this.Padding = new System.Windows.Forms.Padding(0, 75, 0, 0);
            this.Size = new System.Drawing.Size(1561, 912);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.Label facilityTypeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label tildeLabel;
    }
}
