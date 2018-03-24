namespace ElevenAlpha
{
    partial class BookingHistoryFacilities
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BookingFacilityDataGrid = new System.Windows.Forms.DataGridView();
            this.BookingIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequestedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSlotColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TildeLabel = new System.Windows.Forms.Label();
            this.FacilityIdTextBox = new System.Windows.Forms.TextBox();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ShowCancelledCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CancelBookingButton = new System.Windows.Forms.Button();
            this.PrintReceiptButton = new System.Windows.Forms.Button();
            this.ViewReceiptButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingFacilityDataGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BookingFacilityDataGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 706);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BookingFacilityDataGrid
            // 
            this.BookingFacilityDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingFacilityDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookingFacilityDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingFacilityDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingIdColumn,
            this.DateRequestedColumn,
            this.BookingDateColumn,
            this.TimeSlotColumn,
            this.MemberIdColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.StatusColumn});
            this.BookingFacilityDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingFacilityDataGrid.Location = new System.Drawing.Point(3, 79);
            this.BookingFacilityDataGrid.MultiSelect = false;
            this.BookingFacilityDataGrid.Name = "BookingFacilityDataGrid";
            this.BookingFacilityDataGrid.RowTemplate.Height = 40;
            this.BookingFacilityDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookingFacilityDataGrid.Size = new System.Drawing.Size(1290, 529);
            this.BookingFacilityDataGrid.TabIndex = 0;
            // 
            // BookingIdColumn
            // 
            this.BookingIdColumn.DataPropertyName = "BookingId";
            this.BookingIdColumn.HeaderText = "Booking ID";
            this.BookingIdColumn.Name = "BookingIdColumn";
            this.BookingIdColumn.Width = 207;
            // 
            // DateRequestedColumn
            // 
            this.DateRequestedColumn.DataPropertyName = "DateRequested";
            this.DateRequestedColumn.HeaderText = "Date Requested";
            this.DateRequestedColumn.Name = "DateRequestedColumn";
            this.DateRequestedColumn.Width = 274;
            // 
            // BookingDateColumn
            // 
            this.BookingDateColumn.DataPropertyName = "BookingDate";
            this.BookingDateColumn.HeaderText = "Booking Date";
            this.BookingDateColumn.Name = "BookingDateColumn";
            this.BookingDateColumn.Width = 240;
            // 
            // TimeSlotColumn
            // 
            this.TimeSlotColumn.DataPropertyName = "Timeslot";
            this.TimeSlotColumn.HeaderText = "Timeslot";
            this.TimeSlotColumn.Name = "TimeSlotColumn";
            this.TimeSlotColumn.Width = 177;
            // 
            // MemberIdColumn
            // 
            this.MemberIdColumn.DataPropertyName = "MemberID";
            this.MemberIdColumn.HeaderText = "Member ID";
            this.MemberIdColumn.Name = "MemberIdColumn";
            this.MemberIdColumn.Width = 206;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "FirstName";
            this.FirstNameColumn.HeaderText = "First Name";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.Width = 206;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.DataPropertyName = "LastName";
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.Width = 205;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DataPropertyName = "Status";
            this.StatusColumn.HeaderText = "Booking Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Width = 261;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.Controls.Add(this.ToDateTimePicker, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.FromDateTimePicker, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.TildeLabel, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.FacilityIdTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemberIdLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SearchTextBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1290, 50);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(1113, 3);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(174, 38);
            this.ToDateTimePicker.TabIndex = 0;
            this.ToDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(898, 3);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(175, 38);
            this.FromDateTimePicker.TabIndex = 1;
            this.FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // TildeLabel
            // 
            this.TildeLabel.AutoSize = true;
            this.TildeLabel.Location = new System.Drawing.Point(1079, 0);
            this.TildeLabel.Name = "TildeLabel";
            this.TildeLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TildeLabel.Size = new System.Drawing.Size(28, 42);
            this.TildeLabel.TabIndex = 2;
            this.TildeLabel.Text = "~";
            // 
            // FacilityIdTextBox
            // 
            this.FacilityIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacilityIdTextBox.Location = new System.Drawing.Point(698, 3);
            this.FacilityIdTextBox.Name = "FacilityIdTextBox";
            this.FacilityIdTextBox.Size = new System.Drawing.Size(174, 38);
            this.FacilityIdTextBox.TabIndex = 3;
            this.FacilityIdTextBox.TextChanged += new System.EventHandler(this.FacilityIdTextBox_TextChanged);
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(533, 0);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.MemberIdLabel.Size = new System.Drawing.Size(139, 37);
            this.MemberIdLabel.TabIndex = 4;
            this.MemberIdLabel.Text = "Facility ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTextBox.Location = new System.Drawing.Point(115, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(412, 38);
            this.SearchTextBox.TabIndex = 6;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.ShowCancelledCheckBox, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.CloseButton, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.CancelBookingButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.PrintReceiptButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ViewReceiptButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 634);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1290, 69);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // ShowCancelledCheckBox
            // 
            this.ShowCancelledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCancelledCheckBox.AutoSize = true;
            this.ShowCancelledCheckBox.Location = new System.Drawing.Point(1028, 3);
            this.ShowCancelledCheckBox.Name = "ShowCancelledCheckBox";
            this.ShowCancelledCheckBox.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ShowCancelledCheckBox.Size = new System.Drawing.Size(259, 41);
            this.ShowCancelledCheckBox.TabIndex = 0;
            this.ShowCancelledCheckBox.Text = "Show Cancelled";
            this.ShowCancelledCheckBox.UseVisualStyleBackColor = true;
            this.ShowCancelledCheckBox.CheckedChanged += new System.EventHandler(this.ShowCancelledCheckBox_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseButton.Location = new System.Drawing.Point(784, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(147, 43);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CancelBookingButton
            // 
            this.CancelBookingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelBookingButton.Location = new System.Drawing.Point(543, 3);
            this.CancelBookingButton.Name = "CancelBookingButton";
            this.CancelBookingButton.Size = new System.Drawing.Size(235, 43);
            this.CancelBookingButton.TabIndex = 2;
            this.CancelBookingButton.Text = "Cancel Booking";
            this.CancelBookingButton.UseVisualStyleBackColor = true;
            this.CancelBookingButton.Click += new System.EventHandler(this.CancelBookingButton_Click);
            // 
            // PrintReceiptButton
            // 
            this.PrintReceiptButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrintReceiptButton.Location = new System.Drawing.Point(324, 3);
            this.PrintReceiptButton.Name = "PrintReceiptButton";
            this.PrintReceiptButton.Size = new System.Drawing.Size(213, 43);
            this.PrintReceiptButton.TabIndex = 3;
            this.PrintReceiptButton.Text = "Print Receipt";
            this.PrintReceiptButton.UseVisualStyleBackColor = true;
            this.PrintReceiptButton.Click += new System.EventHandler(this.PrintReceiptButton_Click);
            // 
            // ViewReceiptButton
            // 
            this.ViewReceiptButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewReceiptButton.Location = new System.Drawing.Point(113, 3);
            this.ViewReceiptButton.Name = "ViewReceiptButton";
            this.ViewReceiptButton.Size = new System.Drawing.Size(205, 43);
            this.ViewReceiptButton.TabIndex = 4;
            this.ViewReceiptButton.Text = "View Receipt";
            this.ViewReceiptButton.UseVisualStyleBackColor = true;
            this.ViewReceiptButton.Click += new System.EventHandler(this.ViewReceiptButton_Click);
            // 
            // BookingHistoryFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(1496, 706);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookingHistoryFacilities";
            this.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.Text = "Booking History (Facilities)";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookingFacilityDataGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView BookingFacilityDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Label TildeLabel;
        private System.Windows.Forms.TextBox FacilityIdTextBox;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox ShowCancelledCheckBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CancelBookingButton;
        private System.Windows.Forms.Button PrintReceiptButton;
        private System.Windows.Forms.Button ViewReceiptButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequestedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlotColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}