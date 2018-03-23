namespace ElevenAlpha
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
            this.BookingDataGridView = new System.Windows.Forms.DataGridView();
            this.FacilityTypeLabel = new System.Windows.Forms.Label();
            this.FacilityTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TildeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingDataGridView
            // 
            this.BookingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingDataGridView.Location = new System.Drawing.Point(0, 75);
            this.BookingDataGridView.Name = "BookingDataGridView";
            this.BookingDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.BookingDataGridView.RowTemplate.Height = 40;
            this.BookingDataGridView.Size = new System.Drawing.Size(1561, 837);
            this.BookingDataGridView.TabIndex = 0;
            // 
            // FacilityTypeLabel
            // 
            this.FacilityTypeLabel.AutoSize = true;
            this.FacilityTypeLabel.Location = new System.Drawing.Point(26, 21);
            this.FacilityTypeLabel.Name = "FacilityTypeLabel";
            this.FacilityTypeLabel.Size = new System.Drawing.Size(175, 32);
            this.FacilityTypeLabel.TabIndex = 1;
            this.FacilityTypeLabel.Text = "Facility Type";
            // 
            // FacilityTypeComboBox
            // 
            this.FacilityTypeComboBox.FormattingEnabled = true;
            this.FacilityTypeComboBox.Location = new System.Drawing.Point(207, 18);
            this.FacilityTypeComboBox.Name = "FacilityTypeComboBox";
            this.FacilityTypeComboBox.Size = new System.Drawing.Size(365, 39);
            this.FacilityTypeComboBox.TabIndex = 2;
            this.FacilityTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FacilityTypeComboBox_SelectedIndexChanged);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(1097, 19);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(200, 38);
            this.FromDateTimePicker.TabIndex = 3;
            this.FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(1340, 21);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(200, 38);
            this.ToDateTimePicker.TabIndex = 4;
            this.ToDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // TildeLabel
            // 
            this.TildeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TildeLabel.AutoSize = true;
            this.TildeLabel.Location = new System.Drawing.Point(1303, 32);
            this.TildeLabel.Name = "TildeLabel";
            this.TildeLabel.Size = new System.Drawing.Size(31, 32);
            this.TildeLabel.TabIndex = 5;
            this.TildeLabel.Text = "~";
            // 
            // BookingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TildeLabel);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.FacilityTypeComboBox);
            this.Controls.Add(this.FacilityTypeLabel);
            this.Controls.Add(this.BookingDataGridView);
            this.Name = "BookingTab";
            this.Padding = new System.Windows.Forms.Padding(0, 75, 0, 0);
            this.Size = new System.Drawing.Size(1561, 912);
            ((System.ComponentModel.ISupportInitialize)(this.BookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingDataGridView;
        private System.Windows.Forms.Label FacilityTypeLabel;
        private System.Windows.Forms.ComboBox FacilityTypeComboBox;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.Label TildeLabel;
    }
}
