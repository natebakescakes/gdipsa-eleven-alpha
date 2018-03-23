namespace MainScreen
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
            ((System.ComponentModel.ISupportInitialize)(this.MemberInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberInfoTable
            // 
            this.MemberInfoTable.AllowUserToAddRows = false;
            this.MemberInfoTable.AllowUserToDeleteRows = false;
            this.MemberInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberInfoTable.Location = new System.Drawing.Point(56, 30);
            this.MemberInfoTable.Name = "MemberInfoTable";
            this.MemberInfoTable.ReadOnly = true;
            this.MemberInfoTable.RowTemplate.Height = 28;
            this.MemberInfoTable.Size = new System.Drawing.Size(933, 573);
            this.MemberInfoTable.TabIndex = 0;
            // 
            // members_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemberInfoTable);
            this.Name = "members_tab";
            this.Size = new System.Drawing.Size(1024, 697);
            ((System.ComponentModel.ISupportInitialize)(this.MemberInfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MemberInfoTable;
    }
}
