namespace ElevenAlpha
{
    partial class BookingHistoryMembers
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
            this.BookingMemberDataGrid = new System.Windows.Forms.DataGridView();
            this.BookingIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequestedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeslotColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TildeLabel = new System.Windows.Forms.Label();
            this.MemberIdTextBox = new System.Windows.Forms.TextBox();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ShowCancelledCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CancelBookingButton = new System.Windows.Forms.Button();
            this.ViewReceiptButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingMemberDataGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BookingMemberDataGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BookingMemberDataGrid
            // 
            this.BookingMemberDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingMemberDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookingMemberDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingMemberDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingIdColumn,
            this.DateRequestedColumn,
            this.BookingDateColumn,
            this.TimeslotColumn,
            this.FacilityIdColumn,
            this.FacilityNameColumn,
            this.FacilityTypeColumn,
            this.StatusColumn});
            this.BookingMemberDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingMemberDataGrid.Location = new System.Drawing.Point(2, 51);
            this.BookingMemberDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingMemberDataGrid.Name = "BookingMemberDataGrid";
            this.BookingMemberDataGrid.RowTemplate.Height = 40;
            this.BookingMemberDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookingMemberDataGrid.Size = new System.Drawing.Size(966, 341);
            this.BookingMemberDataGrid.TabIndex = 0;
            // 
            // BookingIdColumn
            // 
            this.BookingIdColumn.DataPropertyName = "BookingID";
            this.BookingIdColumn.HeaderText = "Booking ID";
            this.BookingIdColumn.Name = "BookingIdColumn";
            this.BookingIdColumn.Width = 127;
            // 
            // DateRequestedColumn
            // 
            this.DateRequestedColumn.DataPropertyName = "DateRequested";
            this.DateRequestedColumn.HeaderText = "Transaction Date";
            this.DateRequestedColumn.Name = "DateRequestedColumn";
            this.DateRequestedColumn.Width = 174;
            // 
            // BookingDateColumn
            // 
            this.BookingDateColumn.DataPropertyName = "BookingDate";
            this.BookingDateColumn.HeaderText = "Booking Date";
            this.BookingDateColumn.Name = "BookingDateColumn";
            this.BookingDateColumn.Width = 146;
            // 
            // TimeslotColumn
            // 
            this.TimeslotColumn.DataPropertyName = "Timeslot";
            this.TimeslotColumn.HeaderText = "Timeslot";
            this.TimeslotColumn.Name = "TimeslotColumn";
            this.TimeslotColumn.Width = 109;
            // 
            // FacilityIdColumn
            // 
            this.FacilityIdColumn.DataPropertyName = "FacilityID";
            this.FacilityIdColumn.HeaderText = "Facility ID";
            this.FacilityIdColumn.Name = "FacilityIdColumn";
            this.FacilityIdColumn.Width = 120;
            // 
            // FacilityNameColumn
            // 
            this.FacilityNameColumn.DataPropertyName = "FacilityName";
            this.FacilityNameColumn.HeaderText = "Facility Name";
            this.FacilityNameColumn.Name = "FacilityNameColumn";
            this.FacilityNameColumn.Width = 147;
            // 
            // FacilityTypeColumn
            // 
            this.FacilityTypeColumn.DataPropertyName = "FacilityTypeName";
            this.FacilityTypeColumn.HeaderText = "Facility Type";
            this.FacilityTypeColumn.Name = "FacilityTypeColumn";
            this.FacilityTypeColumn.Width = 139;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DataPropertyName = "Status";
            this.StatusColumn.HeaderText = "Booking Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Width = 158;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel2.Controls.Add(this.ToDateTimePicker, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.FromDateTimePicker, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.TildeLabel, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemberIdTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemberIdLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.SearchLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SearchTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FirstNameTextBox, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.LastNameTextBox, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(966, 32);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(827, 2);
            this.ToDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(137, 26);
            this.ToDateTimePicker.TabIndex = 0;
            this.ToDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(666, 2);
            this.FromDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(137, 26);
            this.FromDateTimePicker.TabIndex = 1;
            this.FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // TildeLabel
            // 
            this.TildeLabel.AutoSize = true;
            this.TildeLabel.Location = new System.Drawing.Point(807, 0);
            this.TildeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TildeLabel.Name = "TildeLabel";
            this.TildeLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.TildeLabel.Size = new System.Drawing.Size(16, 26);
            this.TildeLabel.TabIndex = 2;
            this.TildeLabel.Text = "~";
            // 
            // MemberIdTextBox
            // 
            this.MemberIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberIdTextBox.Location = new System.Drawing.Point(297, 2);
            this.MemberIdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MemberIdTextBox.Name = "MemberIdTextBox";
            this.MemberIdTextBox.Size = new System.Drawing.Size(108, 26);
            this.MemberIdTextBox.TabIndex = 3;
            this.MemberIdTextBox.TextChanged += new System.EventHandler(this.MemberIdTextBox_TextChanged);
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(196, 0);
            this.MemberIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MemberIdLabel.Size = new System.Drawing.Size(88, 23);
            this.MemberIdLabel.TabIndex = 4;
            this.MemberIdLabel.Text = "Member ID";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(2, 0);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.SearchLabel.Size = new System.Drawing.Size(60, 23);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTextBox.Location = new System.Drawing.Point(81, 2);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(111, 26);
            this.SearchTextBox.TabIndex = 6;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstNameTextBox.Location = new System.Drawing.Point(420, 2);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(108, 26);
            this.FirstNameTextBox.TabIndex = 7;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastNameTextBox.Location = new System.Drawing.Point(543, 2);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(108, 26);
            this.LastNameTextBox.TabIndex = 8;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel3.Controls.Add(this.ShowCancelledCheckBox, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.CloseButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.CancelBookingButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ViewReceiptButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 409);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(966, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // ShowCancelledCheckBox
            // 
            this.ShowCancelledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCancelledCheckBox.AutoSize = true;
            this.ShowCancelledCheckBox.Location = new System.Drawing.Point(815, 2);
            this.ShowCancelledCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowCancelledCheckBox.Name = "ShowCancelledCheckBox";
            this.ShowCancelledCheckBox.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ShowCancelledCheckBox.Size = new System.Drawing.Size(149, 27);
            this.ShowCancelledCheckBox.TabIndex = 0;
            this.ShowCancelledCheckBox.Text = "Show Cancelled";
            this.ShowCancelledCheckBox.UseVisualStyleBackColor = true;
            this.ShowCancelledCheckBox.CheckedChanged += new System.EventHandler(this.ShowCancelledCheckBox_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseButton.Location = new System.Drawing.Point(516, 2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(82, 28);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CancelBookingButton
            // 
            this.CancelBookingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelBookingButton.Location = new System.Drawing.Point(380, 2);
            this.CancelBookingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBookingButton.Name = "CancelBookingButton";
            this.CancelBookingButton.Size = new System.Drawing.Size(132, 28);
            this.CancelBookingButton.TabIndex = 2;
            this.CancelBookingButton.Text = "Cancel Booking";
            this.CancelBookingButton.UseVisualStyleBackColor = true;
            this.CancelBookingButton.Click += new System.EventHandler(this.CancelBookingButton_Click);
            // 
            // ViewReceiptButton
            // 
            this.ViewReceiptButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewReceiptButton.Location = new System.Drawing.Point(261, 2);
            this.ViewReceiptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewReceiptButton.Name = "ViewReceiptButton";
            this.ViewReceiptButton.Size = new System.Drawing.Size(115, 28);
            this.ViewReceiptButton.TabIndex = 4;
            this.ViewReceiptButton.Text = "View Receipt";
            this.ViewReceiptButton.UseVisualStyleBackColor = true;
            this.ViewReceiptButton.Click += new System.EventHandler(this.ViewReceiptButton_Click);
            // 
            // BookingHistoryMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(1082, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookingHistoryMembers";
            this.Padding = new System.Windows.Forms.Padding(56, 0, 56, 0);
            this.Text = "Booking History (By Members)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookingMemberDataGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView BookingMemberDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Label TildeLabel;
        private System.Windows.Forms.TextBox MemberIdTextBox;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox ShowCancelledCheckBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CancelBookingButton;
        private System.Windows.Forms.Button ViewReceiptButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequestedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeslotColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}