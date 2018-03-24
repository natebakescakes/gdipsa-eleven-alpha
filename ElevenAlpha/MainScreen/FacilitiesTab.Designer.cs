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
            this.FacilitiesdataGridView1 = new System.Windows.Forms.DataGridView();
            this.FacilititesTabBtnNew = new System.Windows.Forms.Button();
            this.FacilitiesTabBtnEdit = new System.Windows.Forms.Button();
            this.FacilitiesTabBtnDeactivate = new System.Windows.Forms.Button();
            this.FacilitiesTabBtnViewHist = new System.Windows.Forms.Button();
            this.ActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.FacilitiesTabBtnActivate = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FacilitiesdataGridView1
            // 
            this.FacilitiesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilitiesdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacilitiesdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.FacilitiesdataGridView1.Name = "FacilitiesdataGridView1";
            this.FacilitiesdataGridView1.RowTemplate.Height = 28;
            this.FacilitiesdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FacilitiesdataGridView1.Size = new System.Drawing.Size(842, 417);
            this.FacilitiesdataGridView1.TabIndex = 1;
            // 
            // FacilititesTabBtnNew
            // 
            this.FacilititesTabBtnNew.Location = new System.Drawing.Point(170, 438);
            this.FacilititesTabBtnNew.Name = "FacilititesTabBtnNew";
            this.FacilititesTabBtnNew.Size = new System.Drawing.Size(66, 29);
            this.FacilititesTabBtnNew.TabIndex = 2;
            this.FacilititesTabBtnNew.Text = "New";
            this.FacilititesTabBtnNew.UseVisualStyleBackColor = true;
            // 
            // FacilitiesTabBtnEdit
            // 
            this.FacilitiesTabBtnEdit.Location = new System.Drawing.Point(242, 438);
            this.FacilitiesTabBtnEdit.Name = "FacilitiesTabBtnEdit";
            this.FacilitiesTabBtnEdit.Size = new System.Drawing.Size(66, 29);
            this.FacilitiesTabBtnEdit.TabIndex = 3;
            this.FacilitiesTabBtnEdit.Text = "Edit";
            this.FacilitiesTabBtnEdit.UseVisualStyleBackColor = true;
            // 
            // FacilitiesTabBtnDeactivate
            // 
            this.FacilitiesTabBtnDeactivate.Location = new System.Drawing.Point(314, 438);
            this.FacilitiesTabBtnDeactivate.Name = "FacilitiesTabBtnDeactivate";
            this.FacilitiesTabBtnDeactivate.Size = new System.Drawing.Size(98, 29);
            this.FacilitiesTabBtnDeactivate.TabIndex = 4;
            this.FacilitiesTabBtnDeactivate.Text = "Deactivate";
            this.FacilitiesTabBtnDeactivate.UseVisualStyleBackColor = true;
            this.FacilitiesTabBtnDeactivate.Click += new System.EventHandler(this.FacilitiesTabBtnDeactivate_Click);
            // 
            // FacilitiesTabBtnViewHist
            // 
            this.FacilitiesTabBtnViewHist.Location = new System.Drawing.Point(512, 438);
            this.FacilitiesTabBtnViewHist.Name = "FacilitiesTabBtnViewHist";
            this.FacilitiesTabBtnViewHist.Size = new System.Drawing.Size(178, 29);
            this.FacilitiesTabBtnViewHist.TabIndex = 5;
            this.FacilitiesTabBtnViewHist.Text = "View Booking History";
            this.FacilitiesTabBtnViewHist.UseVisualStyleBackColor = true;
            // 
            // ActiveCheckbox
            // 
            this.ActiveCheckbox.AutoSize = true;
            this.ActiveCheckbox.Location = new System.Drawing.Point(705, 441);
            this.ActiveCheckbox.Name = "ActiveCheckbox";
            this.ActiveCheckbox.Size = new System.Drawing.Size(134, 24);
            this.ActiveCheckbox.TabIndex = 6;
            this.ActiveCheckbox.Text = "Show Inactive";
            this.ActiveCheckbox.UseVisualStyleBackColor = true;
            this.ActiveCheckbox.CheckedChanged += new System.EventHandler(this.ActiveCheckbox_CheckedChanged);
            this.ActiveCheckbox.Click += new System.EventHandler(this.SearchTextbox_Enter);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SearchTextbox.Location = new System.Drawing.Point(14, 439);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(135, 26);
            this.SearchTextbox.TabIndex = 7;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // FacilitiesTabBtnActivate
            // 
            this.FacilitiesTabBtnActivate.Location = new System.Drawing.Point(418, 438);
            this.FacilitiesTabBtnActivate.Name = "FacilitiesTabBtnActivate";
            this.FacilitiesTabBtnActivate.Size = new System.Drawing.Size(75, 29);
            this.FacilitiesTabBtnActivate.TabIndex = 8;
            this.FacilitiesTabBtnActivate.Text = "Activate";
            this.FacilitiesTabBtnActivate.UseVisualStyleBackColor = true;
            this.FacilitiesTabBtnActivate.Click += new System.EventHandler(this.FacilitiesTabBtnActivate_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(21, 420);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(53, 17);
            this.SearchLabel.TabIndex = 9;
            this.SearchLabel.Text = "Search";
            // 
            // FacilitiesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.FacilitiesTabBtnActivate);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.ActiveCheckbox);
            this.Controls.Add(this.FacilitiesTabBtnViewHist);
            this.Controls.Add(this.FacilitiesTabBtnDeactivate);
            this.Controls.Add(this.FacilitiesTabBtnEdit);
            this.Controls.Add(this.FacilititesTabBtnNew);
            this.Controls.Add(this.FacilitiesdataGridView1);
            this.Name = "FacilitiesTab";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.Size = new System.Drawing.Size(842, 492);
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView FacilitiesdataGridView1;
        private System.Windows.Forms.Button FacilititesTabBtnNew;
        private System.Windows.Forms.Button FacilitiesTabBtnEdit;
        private System.Windows.Forms.Button FacilitiesTabBtnDeactivate;
        private System.Windows.Forms.Button FacilitiesTabBtnViewHist;
        private System.Windows.Forms.CheckBox ActiveCheckbox;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button FacilitiesTabBtnActivate;
        private System.Windows.Forms.Label SearchLabel;
    }
}
