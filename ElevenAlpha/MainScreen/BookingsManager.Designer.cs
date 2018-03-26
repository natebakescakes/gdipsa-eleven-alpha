namespace ElevenAlpha
{
    partial class BookingsManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.MemberIdTextBox = new System.Windows.Forms.TextBox();
            this.ShowMemberLookupButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.BookingDateLabel = new System.Windows.Forms.Label();
            this.BookingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FacilityTypeLabel = new System.Windows.Forms.Label();
            this.FacilityTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BookButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PreviousDayButton = new System.Windows.Forms.Button();
            this.NextDayButton = new System.Windows.Forms.Button();
            this.BookingManagerDataGrid = new System.Windows.Forms.DataGridView();
            this.BookButton1 = new System.Windows.Forms.Button();
            this.CloseButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingManagerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(53, 25);
            this.MemberIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(88, 20);
            this.MemberIdLabel.TabIndex = 1;
            this.MemberIdLabel.Text = "Member ID";
            // 
            // MemberIdTextBox
            // 
            this.MemberIdTextBox.Location = new System.Drawing.Point(166, 23);
            this.MemberIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MemberIdTextBox.Name = "MemberIdTextBox";
            this.MemberIdTextBox.Size = new System.Drawing.Size(91, 26);
            this.MemberIdTextBox.TabIndex = 2;
            this.MemberIdTextBox.TextChanged += new System.EventHandler(this.MemberIdTextBox_TextChanged);
            // 
            // ShowMemberLookupButton
            // 
            this.ShowMemberLookupButton.Location = new System.Drawing.Point(259, 23);
            this.ShowMemberLookupButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowMemberLookupButton.Name = "ShowMemberLookupButton";
            this.ShowMemberLookupButton.Size = new System.Drawing.Size(28, 25);
            this.ShowMemberLookupButton.TabIndex = 3;
            this.ShowMemberLookupButton.Text = "...";
            this.ShowMemberLookupButton.UseVisualStyleBackColor = true;
            this.ShowMemberLookupButton.Click += new System.EventHandler(this.ShowMemberLookupButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstNameTextBox.Location = new System.Drawing.Point(400, 23);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(145, 26);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(547, 23);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(145, 26);
            this.LastNameTextBox.TabIndex = 5;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // BookingDateLabel
            // 
            this.BookingDateLabel.AutoSize = true;
            this.BookingDateLabel.Location = new System.Drawing.Point(53, 56);
            this.BookingDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingDateLabel.Name = "BookingDateLabel";
            this.BookingDateLabel.Size = new System.Drawing.Size(106, 20);
            this.BookingDateLabel.TabIndex = 6;
            this.BookingDateLabel.Text = "Booking Date";
            // 
            // BookingDateTimePicker
            // 
            this.BookingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDateTimePicker.Location = new System.Drawing.Point(166, 52);
            this.BookingDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.BookingDateTimePicker.MinDate = new System.DateTime(2018, 3, 26, 0, 0, 0, 0);
            this.BookingDateTimePicker.Name = "BookingDateTimePicker";
            this.BookingDateTimePicker.Size = new System.Drawing.Size(122, 26);
            this.BookingDateTimePicker.TabIndex = 7;
            this.BookingDateTimePicker.ValueChanged += new System.EventHandler(this.BookingDateTimePicker_ValueChanged);
            // 
            // FacilityTypeLabel
            // 
            this.FacilityTypeLabel.AutoSize = true;
            this.FacilityTypeLabel.Location = new System.Drawing.Point(445, 55);
            this.FacilityTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityTypeLabel.Name = "FacilityTypeLabel";
            this.FacilityTypeLabel.Size = new System.Drawing.Size(95, 20);
            this.FacilityTypeLabel.TabIndex = 8;
            this.FacilityTypeLabel.Text = "Facility Type";
            // 
            // FacilityTypeComboBox
            // 
            this.FacilityTypeComboBox.FormattingEnabled = true;
            this.FacilityTypeComboBox.Location = new System.Drawing.Point(547, 54);
            this.FacilityTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FacilityTypeComboBox.Name = "FacilityTypeComboBox";
            this.FacilityTypeComboBox.Size = new System.Drawing.Size(145, 28);
            this.FacilityTypeComboBox.TabIndex = 9;
            this.FacilityTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FacilityTypeComboBox_SelectedIndexChanged);
            // 
            // BookButton
            // 
            this.BookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BookButton.Location = new System.Drawing.Point(324, 840);
            this.BookButton.Margin = new System.Windows.Forms.Padding(2);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(72, 30);
            this.BookButton.TabIndex = 10;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(400, 840);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(72, 30);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            //this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PreviousDayButton
            // 
            this.PreviousDayButton.Location = new System.Drawing.Point(290, 54);
            this.PreviousDayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PreviousDayButton.Name = "PreviousDayButton";
            this.PreviousDayButton.Size = new System.Drawing.Size(28, 25);
            this.PreviousDayButton.TabIndex = 12;
            this.PreviousDayButton.Text = "<";
            this.PreviousDayButton.UseVisualStyleBackColor = true;
            this.PreviousDayButton.Click += new System.EventHandler(this.PreviousDayButton_Click);
            // 
            // NextDayButton
            // 
            this.NextDayButton.Location = new System.Drawing.Point(321, 54);
            this.NextDayButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextDayButton.Name = "NextDayButton";
            this.NextDayButton.Size = new System.Drawing.Size(28, 25);
            this.NextDayButton.TabIndex = 13;
            this.NextDayButton.Text = ">";
            this.NextDayButton.UseVisualStyleBackColor = true;
            this.NextDayButton.Click += new System.EventHandler(this.NextDayButton_Click);
            // 
            // BookingManagerDataGrid
            // 
            this.BookingManagerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingManagerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BookingManagerDataGrid.ColumnHeadersHeight = 80;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingManagerDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.BookingManagerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingManagerDataGrid.Location = new System.Drawing.Point(56, 97);
            this.BookingManagerDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.BookingManagerDataGrid.MultiSelect = false;
            this.BookingManagerDataGrid.Name = "BookingManagerDataGrid";
            this.BookingManagerDataGrid.ReadOnly = true;
            this.BookingManagerDataGrid.RowHeadersWidth = 250;
            this.BookingManagerDataGrid.RowTemplate.Height = 80;
            this.BookingManagerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BookingManagerDataGrid.Size = new System.Drawing.Size(677, 483);
            this.BookingManagerDataGrid.TabIndex = 0;
            this.BookingManagerDataGrid.DoubleClick += new System.EventHandler(this.BookingManagerDataGrid_DoubleClick);
            // 
            // BookButton1
            // 
            this.BookButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BookButton1.Location = new System.Drawing.Point(273, 611);
            this.BookButton1.Name = "BookButton1";
            this.BookButton1.Size = new System.Drawing.Size(106, 30);
            this.BookButton1.TabIndex = 14;
            this.BookButton1.Text = "Book";
            this.BookButton1.UseVisualStyleBackColor = true;
            this.BookButton1.Click += new System.EventHandler(this.BookButton1_Click);
            // 
            // CloseButton1
            // 
            this.CloseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton1.Location = new System.Drawing.Point(385, 611);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(106, 30);
            this.CloseButton1.TabIndex = 15;
            this.CloseButton1.Text = "Close";
            this.CloseButton1.UseVisualStyleBackColor = true;
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // BookingsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(789, 677);
            this.Controls.Add(this.CloseButton1);
            this.Controls.Add(this.BookButton1);
            this.Controls.Add(this.NextDayButton);
            this.Controls.Add(this.PreviousDayButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.FacilityTypeComboBox);
            this.Controls.Add(this.FacilityTypeLabel);
            this.Controls.Add(this.BookingDateTimePicker);
            this.Controls.Add(this.BookingDateLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.ShowMemberLookupButton);
            this.Controls.Add(this.MemberIdTextBox);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.BookingManagerDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingsManager";
            this.Padding = new System.Windows.Forms.Padding(56, 97, 56, 97);
            this.Text = "Booking Manager";
            ((System.ComponentModel.ISupportInitialize)(this.BookingManagerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Button ShowMemberLookupButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label BookingDateLabel;
        private System.Windows.Forms.DateTimePicker BookingDateTimePicker;
        private System.Windows.Forms.Label FacilityTypeLabel;
        private System.Windows.Forms.ComboBox FacilityTypeComboBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button PreviousDayButton;
        private System.Windows.Forms.Button NextDayButton;
        public System.Windows.Forms.TextBox MemberIdTextBox;
        public System.Windows.Forms.DataGridView BookingManagerDataGrid;
        private System.Windows.Forms.Button BookButton1;
        private System.Windows.Forms.Button CloseButton1;
    }
}