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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FacilityType = new System.Windows.Forms.Label();
            this.FacilityNameTextB = new System.Windows.Forms.TextBox();
            this.OpenTimeMaskT = new System.Windows.Forms.MaskedTextBox();
            this.CloseTimeMaskT = new System.Windows.Forms.MaskedTextBox();
            this.LocationTextB = new System.Windows.Forms.TextBox();
            this.DescriptionTextB = new System.Windows.Forms.TextBox();
            this.FacilityTypeComB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facility Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Open Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Close Time";
            // 
            // FacilityType
            // 
            this.FacilityType.AutoSize = true;
            this.FacilityType.Location = new System.Drawing.Point(372, 30);
            this.FacilityType.Name = "FacilityType";
            this.FacilityType.Size = new System.Drawing.Size(111, 15);
            this.FacilityType.TabIndex = 5;
            this.FacilityType.Text = "Facility Type";
            // 
            // FacilityNameTextB
            // 
            this.FacilityNameTextB.Location = new System.Drawing.Point(175, 27);
            this.FacilityNameTextB.Name = "FacilityNameTextB";
            this.FacilityNameTextB.Size = new System.Drawing.Size(100, 25);
            this.FacilityNameTextB.TabIndex = 7;
            // 
            // OpenTimeMaskT
            // 
            this.OpenTimeMaskT.Location = new System.Drawing.Point(175, 99);
            this.OpenTimeMaskT.Mask = "00:00";
            this.OpenTimeMaskT.Name = "OpenTimeMaskT";
            this.OpenTimeMaskT.Size = new System.Drawing.Size(100, 25);
            this.OpenTimeMaskT.TabIndex = 8;
            // 
            // CloseTimeMaskT
            // 
            this.CloseTimeMaskT.Location = new System.Drawing.Point(489, 99);
            this.CloseTimeMaskT.Mask = "00:00";
            this.CloseTimeMaskT.Name = "CloseTimeMaskT";
            this.CloseTimeMaskT.Size = new System.Drawing.Size(100, 25);
            this.CloseTimeMaskT.TabIndex = 9;
            this.CloseTimeMaskT.ValidatingType = typeof(System.DateTime);
            // 
            // LocationTextB
            // 
            this.LocationTextB.Location = new System.Drawing.Point(175, 182);
            this.LocationTextB.Name = "LocationTextB";
            this.LocationTextB.Size = new System.Drawing.Size(100, 25);
            this.LocationTextB.TabIndex = 10;
            // 
            // DescriptionTextB
            // 
            this.DescriptionTextB.Location = new System.Drawing.Point(175, 261);
            this.DescriptionTextB.Multiline = true;
            this.DescriptionTextB.Name = "DescriptionTextB";
            this.DescriptionTextB.Size = new System.Drawing.Size(425, 155);
            this.DescriptionTextB.TabIndex = 11;
            // 
            // FacilityTypeComB
            // 
            this.FacilityTypeComB.FormattingEnabled = true;
            this.FacilityTypeComB.Location = new System.Drawing.Point(489, 30);
            this.FacilityTypeComB.Name = "FacilityTypeComB";
            this.FacilityTypeComB.Size = new System.Drawing.Size(121, 23);
            this.FacilityTypeComB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "(XX:00)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "(XX:00)";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(187, 454);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(402, 454);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 501);
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
            this.Name = "EditFacility";
            this.Text = "EditFacility";
            this.Load += new System.EventHandler(this.EditFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FacilityType;
        private System.Windows.Forms.TextBox FacilityNameTextB;
        private System.Windows.Forms.MaskedTextBox OpenTimeMaskT;
        private System.Windows.Forms.MaskedTextBox CloseTimeMaskT;
        private System.Windows.Forms.TextBox LocationTextB;
        private System.Windows.Forms.TextBox DescriptionTextB;
        private System.Windows.Forms.ComboBox FacilityTypeComB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button CloseButton;
    }
}