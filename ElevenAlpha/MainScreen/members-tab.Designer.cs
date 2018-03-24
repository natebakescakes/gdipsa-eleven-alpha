namespace ElevenAlpha
{
    partial class members_tab
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
            this.MemberInfoTable = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BookHstryBttn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.InactiveCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MemberInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberInfoTable
            // 
            this.MemberInfoTable.AllowUserToOrderColumns = true;
            this.MemberInfoTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MemberInfoTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MemberInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberInfoTable.Location = new System.Drawing.Point(0, 0);
            this.MemberInfoTable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MemberInfoTable.Name = "MemberInfoTable";
            this.MemberInfoTable.RowTemplate.Height = 28;
            this.MemberInfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberInfoTable.Size = new System.Drawing.Size(1834, 682);
            this.MemberInfoTable.TabIndex = 0;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewButton.Location = new System.Drawing.Point(493, 735);
            this.NewButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(169, 45);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditButton.Location = new System.Drawing.Point(672, 735);
            this.EditButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(169, 45);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(851, 735);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(169, 45);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BookHstryBttn
            // 
            this.BookHstryBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BookHstryBttn.Location = new System.Drawing.Point(1030, 735);
            this.BookHstryBttn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BookHstryBttn.Name = "BookHstryBttn";
            this.BookHstryBttn.Size = new System.Drawing.Size(325, 45);
            this.BookHstryBttn.TabIndex = 4;
            this.BookHstryBttn.Text = "View Booking History";
            this.BookHstryBttn.UseVisualStyleBackColor = true;
            this.BookHstryBttn.Click += new System.EventHandler(this.BookHstryBttn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchTextBox.Location = new System.Drawing.Point(120, 738);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(561, 38);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // InactiveCheckbox
            // 
            this.InactiveCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InactiveCheckbox.AutoSize = true;
            this.InactiveCheckbox.Location = new System.Drawing.Point(1485, 740);
            this.InactiveCheckbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.InactiveCheckbox.Name = "InactiveCheckbox";
            this.InactiveCheckbox.Size = new System.Drawing.Size(344, 36);
            this.InactiveCheckbox.TabIndex = 6;
            this.InactiveCheckbox.Text = "View Inactive Members";
            this.InactiveCheckbox.UseVisualStyleBackColor = true;
            this.InactiveCheckbox.CheckedChanged += new System.EventHandler(this.InactiveCheckbox_CheckedChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(5, 741);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(105, 32);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "Search";
            // 
            // members_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.InactiveCheckbox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BookHstryBttn);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.MemberInfoTable);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "members_tab";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 150);
            this.Size = new System.Drawing.Size(1834, 832);
            this.Load += new System.EventHandler(this.members_tab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberInfoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MemberInfoTable;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BookHstryBttn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.CheckBox InactiveCheckbox;
        private System.Windows.Forms.Label SearchLabel;
    }
}
