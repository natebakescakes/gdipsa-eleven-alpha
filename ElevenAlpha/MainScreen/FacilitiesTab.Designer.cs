namespace ElevenAlpha
{
    partial class FacilitiesTab
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FacilititesTabBtnNew = new System.Windows.Forms.Button();
            this.FacilitiesTabBtnEdit = new System.Windows.Forms.Button();
            this.FacilitiesTabBtnDelete = new System.Windows.Forms.Button();
            this.FacilitiesTabBtnViewHist = new System.Windows.Forms.Button();
            this.ActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(842, 417);
            this.dataGridView1.TabIndex = 1;
            // 
            // FacilititesTabBtnNew
            // 
            this.FacilititesTabBtnNew.Location = new System.Drawing.Point(224, 439);
            this.FacilititesTabBtnNew.Name = "FacilititesTabBtnNew";
            this.FacilititesTabBtnNew.Size = new System.Drawing.Size(75, 29);
            this.FacilititesTabBtnNew.TabIndex = 2;
            this.FacilititesTabBtnNew.Text = "New";
            this.FacilititesTabBtnNew.UseVisualStyleBackColor = true;
            // 
            // FacilitiesTabBtnEdit
            // 
            this.FacilitiesTabBtnEdit.Location = new System.Drawing.Point(305, 439);
            this.FacilitiesTabBtnEdit.Name = "FacilitiesTabBtnEdit";
            this.FacilitiesTabBtnEdit.Size = new System.Drawing.Size(75, 29);
            this.FacilitiesTabBtnEdit.TabIndex = 3;
            this.FacilitiesTabBtnEdit.Text = "Edit";
            this.FacilitiesTabBtnEdit.UseVisualStyleBackColor = true;
            // 
            // FacilitiesTabBtnDelete
            // 
            this.FacilitiesTabBtnDelete.Location = new System.Drawing.Point(386, 439);
            this.FacilitiesTabBtnDelete.Name = "FacilitiesTabBtnDelete";
            this.FacilitiesTabBtnDelete.Size = new System.Drawing.Size(75, 29);
            this.FacilitiesTabBtnDelete.TabIndex = 4;
            this.FacilitiesTabBtnDelete.Text = "Delete";
            this.FacilitiesTabBtnDelete.UseVisualStyleBackColor = true;
            // 
            // FacilitiesTabBtnViewHist
            // 
            this.FacilitiesTabBtnViewHist.Location = new System.Drawing.Point(467, 439);
            this.FacilitiesTabBtnViewHist.Name = "FacilitiesTabBtnViewHist";
            this.FacilitiesTabBtnViewHist.Size = new System.Drawing.Size(178, 29);
            this.FacilitiesTabBtnViewHist.TabIndex = 5;
            this.FacilitiesTabBtnViewHist.Text = "View Booking History";
            this.FacilitiesTabBtnViewHist.UseVisualStyleBackColor = true;
            // 
            // ActiveCheckbox
            // 
            this.ActiveCheckbox.AutoSize = true;
            this.ActiveCheckbox.Location = new System.Drawing.Point(678, 439);
            this.ActiveCheckbox.Name = "ActiveCheckbox";
            this.ActiveCheckbox.Size = new System.Drawing.Size(134, 24);
            this.ActiveCheckbox.TabIndex = 6;
            this.ActiveCheckbox.Text = "Show Inactive";
            this.ActiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SearchTextbox.Location = new System.Drawing.Point(16, 439);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(184, 26);
            this.SearchTextbox.TabIndex = 7;
            this.SearchTextbox.Text = "Search...";
            this.SearchTextbox.Enter += new System.EventHandler(this.SearchTextbox_Enter);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave);
            // 
            // FacilitiesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.ActiveCheckbox);
            this.Controls.Add(this.FacilitiesTabBtnViewHist);
            this.Controls.Add(this.FacilitiesTabBtnDelete);
            this.Controls.Add(this.FacilitiesTabBtnEdit);
            this.Controls.Add(this.FacilititesTabBtnNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FacilitiesTab";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.Size = new System.Drawing.Size(842, 492);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FacilititesTabBtnNew;
        private System.Windows.Forms.Button FacilitiesTabBtnEdit;
        private System.Windows.Forms.Button FacilitiesTabBtnDelete;
        private System.Windows.Forms.Button FacilitiesTabBtnViewHist;
        private System.Windows.Forms.CheckBox ActiveCheckbox;
        private System.Windows.Forms.TextBox SearchTextbox;
    }
}
