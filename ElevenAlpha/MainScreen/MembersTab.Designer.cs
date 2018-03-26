namespace ElevenAlpha
{
    partial class MembersTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MemberInfoTable = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BookHstryBttn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.HideInactiveCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ActivateMemberButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberInfoTable
            // 
            this.MemberInfoTable.AllowUserToOrderColumns = true;
            this.MemberInfoTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MemberInfoTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MemberInfoTable.ColumnHeadersHeight = 40;
            this.MemberInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberInfoTable.Location = new System.Drawing.Point(0, 0);
            this.MemberInfoTable.Margin = new System.Windows.Forms.Padding(5);
            this.MemberInfoTable.MultiSelect = false;
            this.MemberInfoTable.Name = "MemberInfoTable";
            this.MemberInfoTable.RowTemplate.Height = 28;
            this.MemberInfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberInfoTable.Size = new System.Drawing.Size(1040, 395);
            this.MemberInfoTable.TabIndex = 0;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewButton.Location = new System.Drawing.Point(245, 430);
            this.NewButton.Margin = new System.Windows.Forms.Padding(5);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(78, 29);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditButton.Location = new System.Drawing.Point(334, 430);
            this.EditButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(108, 29);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(448, 430);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 29);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Deactivate";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BookHstryBttn
            // 
            this.BookHstryBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BookHstryBttn.Location = new System.Drawing.Point(672, 430);
            this.BookHstryBttn.Margin = new System.Windows.Forms.Padding(5);
            this.BookHstryBttn.Name = "BookHstryBttn";
            this.BookHstryBttn.Size = new System.Drawing.Size(185, 29);
            this.BookHstryBttn.TabIndex = 4;
            this.BookHstryBttn.Text = "View Booking History";
            this.BookHstryBttn.UseVisualStyleBackColor = true;
            this.BookHstryBttn.Click += new System.EventHandler(this.BookHstryBttn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchTextBox.Location = new System.Drawing.Point(69, 430);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(335, 26);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // HideInactiveCheckbox
            // 
            this.HideInactiveCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HideInactiveCheckbox.AutoSize = true;
            this.HideInactiveCheckbox.Location = new System.Drawing.Point(830, 430);
            this.HideInactiveCheckbox.Name = "HideInactiveCheckbox";
            this.HideInactiveCheckbox.Size = new System.Drawing.Size(197, 24);
            this.HideInactiveCheckbox.TabIndex = 6;
            this.HideInactiveCheckbox.Text = "Hide Inactive Members";
            this.HideInactiveCheckbox.UseVisualStyleBackColor = true;
            this.HideInactiveCheckbox.CheckedChanged += new System.EventHandler(this.HideInactiveCheckbox_CheckedChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(5, 430);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(60, 20);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "Search";
            // 
            // ActivateMemberButton
            // 
            this.ActivateMemberButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ActivateMemberButton.Location = new System.Drawing.Point(556, 430);
            this.ActivateMemberButton.Margin = new System.Windows.Forms.Padding(5);
            this.ActivateMemberButton.Name = "ActivateMemberButton";
            this.ActivateMemberButton.Size = new System.Drawing.Size(109, 29);
            this.ActivateMemberButton.TabIndex = 9;
            this.ActivateMemberButton.Text = "Activate";
            this.ActivateMemberButton.UseVisualStyleBackColor = true;
            this.ActivateMemberButton.Click += new System.EventHandler(this.ActivateMemberButton_Click);
            // 
            // MembersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActivateMemberButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.HideInactiveCheckbox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BookHstryBttn);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.MemberInfoTable);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MembersTab";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 97);
            this.Size = new System.Drawing.Size(1040, 492);
            this.Load += new System.EventHandler(this.members_tab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberInfoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BookHstryBttn;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button ActivateMemberButton;
        public System.Windows.Forms.DataGridView MemberInfoTable;
        public System.Windows.Forms.CheckBox HideInactiveCheckbox;
        public System.Windows.Forms.TextBox SearchTextBox;
    }
}
