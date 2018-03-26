namespace ElevenAlpha
{
    partial class EditFacility
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FacilityType = new System.Windows.Forms.Label();
            this.FacilityNameTextB = new System.Windows.Forms.TextBox();
            this.LocationTextB = new System.Windows.Forms.TextBox();
            this.DescriptionTextB = new System.Windows.Forms.TextBox();
            this.FacilityTypeComB = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseTimeMaskT = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenTimeMaskT = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facility Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // FacilityType
            // 
            this.FacilityType.AutoSize = true;
            this.FacilityType.Location = new System.Drawing.Point(401, 49);
            this.FacilityType.Name = "FacilityType";
            this.FacilityType.Size = new System.Drawing.Size(95, 20);
            this.FacilityType.TabIndex = 5;
            this.FacilityType.Text = "Facility Type";
            // 
            // FacilityNameTextB
            // 
            this.FacilityNameTextB.Location = new System.Drawing.Point(148, 46);
            this.FacilityNameTextB.Margin = new System.Windows.Forms.Padding(6);
            this.FacilityNameTextB.Name = "FacilityNameTextB";
            this.FacilityNameTextB.Size = new System.Drawing.Size(229, 26);
            this.FacilityNameTextB.TabIndex = 7;
            // 
            // LocationTextB
            // 
            this.LocationTextB.Location = new System.Drawing.Point(148, 142);
            this.LocationTextB.Margin = new System.Windows.Forms.Padding(6);
            this.LocationTextB.Name = "LocationTextB";
            this.LocationTextB.Size = new System.Drawing.Size(583, 26);
            this.LocationTextB.TabIndex = 10;
            // 
            // DescriptionTextB
            // 
            this.DescriptionTextB.Location = new System.Drawing.Point(148, 190);
            this.DescriptionTextB.Margin = new System.Windows.Forms.Padding(6);
            this.DescriptionTextB.Multiline = true;
            this.DescriptionTextB.Name = "DescriptionTextB";
            this.DescriptionTextB.Size = new System.Drawing.Size(583, 247);
            this.DescriptionTextB.TabIndex = 11;
            // 
            // FacilityTypeComB
            // 
            this.FacilityTypeComB.FormattingEnabled = true;
            this.FacilityTypeComB.Location = new System.Drawing.Point(504, 47);
            this.FacilityTypeComB.Margin = new System.Windows.Forms.Padding(6);
            this.FacilityTypeComB.Name = "FacilityTypeComB";
            this.FacilityTypeComB.Size = new System.Drawing.Size(227, 28);
            this.FacilityTypeComB.TabIndex = 12;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(315, 467);
            this.updateButton.Margin = new System.Windows.Forms.Padding(6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(128, 31);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update Facility";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(450, 467);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 31);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1210, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "(XX:00)";
            // 
            // CloseTimeMaskT
            // 
            this.CloseTimeMaskT.Location = new System.Drawing.Point(504, 96);
            this.CloseTimeMaskT.Margin = new System.Windows.Forms.Padding(6);
            this.CloseTimeMaskT.Mask = "00:00";
            this.CloseTimeMaskT.Name = "CloseTimeMaskT";
            this.CloseTimeMaskT.ReadOnly = true;
            this.CloseTimeMaskT.Size = new System.Drawing.Size(167, 26);
            this.CloseTimeMaskT.TabIndex = 9;
            this.CloseTimeMaskT.Text = "2000";
            this.CloseTimeMaskT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseTimeMaskT.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Closing Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "(XX:00)";
            // 
            // OpenTimeMaskT
            // 
            this.OpenTimeMaskT.Location = new System.Drawing.Point(148, 94);
            this.OpenTimeMaskT.Margin = new System.Windows.Forms.Padding(6);
            this.OpenTimeMaskT.Mask = "00:00";
            this.OpenTimeMaskT.Name = "OpenTimeMaskT";
            this.OpenTimeMaskT.ReadOnly = true;
            this.OpenTimeMaskT.Size = new System.Drawing.Size(165, 26);
            this.OpenTimeMaskT.TabIndex = 8;
            this.OpenTimeMaskT.Text = "0800";
            this.OpenTimeMaskT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpenTimeMaskT.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opening Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "(XX:00)";
            // 
            // EditFacility
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(831, 550);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FacilityTypeComB);
            this.Controls.Add(this.DescriptionTextB);
            this.Controls.Add(this.LocationTextB);
            this.Controls.Add(this.CloseTimeMaskT);
            this.Controls.Add(this.OpenTimeMaskT);
            this.Controls.Add(this.FacilityNameTextB);
            this.Controls.Add(this.FacilityType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditFacility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Facility";
            this.Load += new System.EventHandler(this.EditFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FacilityType;
        private System.Windows.Forms.TextBox FacilityNameTextB;
        private System.Windows.Forms.TextBox LocationTextB;
        private System.Windows.Forms.TextBox DescriptionTextB;
        private System.Windows.Forms.ComboBox FacilityTypeComB;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox CloseTimeMaskT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox OpenTimeMaskT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}