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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MemberInfoTable = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BookHstryBttn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.HideInactiveCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ActivateMemberButton = new System.Windows.Forms.Button();
            this.MemberListCR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberInfoTable
            // 
            this.MemberInfoTable.AllowUserToOrderColumns = true;
            this.MemberInfoTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MemberInfoTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MemberInfoTable.ColumnHeadersHeight = 40;
            this.MemberInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberInfoTable.Location = new System.Drawing.Point(0, 0);
            this.MemberInfoTable.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.MemberInfoTable.MultiSelect = false;
            this.MemberInfoTable.Name = "MemberInfoTable";
            this.MemberInfoTable.RowTemplate.Height = 28;
            this.MemberInfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberInfoTable.Size = new System.Drawing.Size(1849, 613);
            this.MemberInfoTable.TabIndex = 0;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewButton.Location = new System.Drawing.Point(212, 666);
            this.NewButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(139, 45);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditButton.Location = new System.Drawing.Point(370, 666);
            this.EditButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(192, 45);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(572, 666);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(180, 45);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Deactivate";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BookHstryBttn
            // 
            this.BookHstryBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BookHstryBttn.Location = new System.Drawing.Point(971, 666);
            this.BookHstryBttn.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.BookHstryBttn.Name = "BookHstryBttn";
            this.BookHstryBttn.Size = new System.Drawing.Size(329, 45);
            this.BookHstryBttn.TabIndex = 4;
            this.BookHstryBttn.Text = "View Booking History";
            this.BookHstryBttn.UseVisualStyleBackColor = true;
            this.BookHstryBttn.Click += new System.EventHandler(this.BookHstryBttn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchTextBox.Location = new System.Drawing.Point(120, 670);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(592, 38);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // HideInactiveCheckbox
            // 
            this.HideInactiveCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HideInactiveCheckbox.AutoSize = true;
            this.HideInactiveCheckbox.Location = new System.Drawing.Point(1503, 671);
            this.HideInactiveCheckbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HideInactiveCheckbox.Name = "HideInactiveCheckbox";
            this.HideInactiveCheckbox.Size = new System.Drawing.Size(341, 36);
            this.HideInactiveCheckbox.TabIndex = 6;
            this.HideInactiveCheckbox.Text = "Hide Inactive Members";
            this.HideInactiveCheckbox.UseVisualStyleBackColor = true;
            this.HideInactiveCheckbox.CheckedChanged += new System.EventHandler(this.HideInactiveCheckbox_CheckedChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(9, 673);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(105, 32);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "Search";
            // 
            // ActivateMemberButton
            // 
            this.ActivateMemberButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ActivateMemberButton.Location = new System.Drawing.Point(764, 666);
            this.ActivateMemberButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ActivateMemberButton.Name = "ActivateMemberButton";
            this.ActivateMemberButton.Size = new System.Drawing.Size(194, 45);
            this.ActivateMemberButton.TabIndex = 9;
            this.ActivateMemberButton.Text = "Activate";
            this.ActivateMemberButton.UseVisualStyleBackColor = true;
            this.ActivateMemberButton.Click += new System.EventHandler(this.ActivateMemberButton_Click);
            // 
            // MemberListCR
            // 
            this.MemberListCR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MemberListCR.Location = new System.Drawing.Point(1307, 666);
            this.MemberListCR.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MemberListCR.Name = "MemberListCR";
            this.MemberListCR.Size = new System.Drawing.Size(313, 45);
            this.MemberListCR.TabIndex = 10;
            this.MemberListCR.Text = "View Member Report";
            this.MemberListCR.UseVisualStyleBackColor = true;
            this.MemberListCR.Click += new System.EventHandler(this.MemberListCR_Click);
            // 
            // MembersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemberListCR);
            this.Controls.Add(this.ActivateMemberButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.HideInactiveCheckbox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BookHstryBttn);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.MemberInfoTable);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "MembersTab";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 150);
            this.Size = new System.Drawing.Size(1849, 763);
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
        private System.Windows.Forms.Button MemberListCR;
    }
}
