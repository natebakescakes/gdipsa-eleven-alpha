namespace ElevenAlpha
{
    partial class CreateFacility
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
            this.FacilityNameTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FacilityTypeComB = new System.Windows.Forms.ComboBox();
            this.OpenHrsMskTxB = new System.Windows.Forms.MaskedTextBox();
            this.CloseHrsMskTxB = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LocationTexB = new System.Windows.Forms.TextBox();
            this.DescriptionTexB = new System.Windows.Forms.TextBox();
            this.AddFacilityButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FacilityNameTxtB
            // 
            this.FacilityNameTxtB.Location = new System.Drawing.Point(255, 41);
            this.FacilityNameTxtB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FacilityNameTxtB.Name = "FacilityNameTxtB";
            this.FacilityNameTxtB.Size = new System.Drawing.Size(404, 38);
            this.FacilityNameTxtB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faclity Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opening Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Facility Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Closing Hours";
            // 
            // FacilityTypeComB
            // 
            this.FacilityTypeComB.FormattingEnabled = true;
            this.FacilityTypeComB.Location = new System.Drawing.Point(876, 40);
            this.FacilityTypeComB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FacilityTypeComB.Name = "FacilityTypeComB";
            this.FacilityTypeComB.Size = new System.Drawing.Size(412, 39);
            this.FacilityTypeComB.TabIndex = 9;
            this.FacilityTypeComB.SelectedIndexChanged += new System.EventHandler(this.FacilityTypeComB_SelectedIndexChanged);
            // 
            // OpenHrsMskTxB
            // 
            this.OpenHrsMskTxB.Location = new System.Drawing.Point(255, 91);
            this.OpenHrsMskTxB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OpenHrsMskTxB.Mask = "00:00";
            this.OpenHrsMskTxB.Name = "OpenHrsMskTxB";
            this.OpenHrsMskTxB.Size = new System.Drawing.Size(281, 38);
            this.OpenHrsMskTxB.TabIndex = 10;
            this.OpenHrsMskTxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpenHrsMskTxB.ValidatingType = typeof(System.DateTime);
            // 
            // CloseHrsMskTxB
            // 
            this.CloseHrsMskTxB.Location = new System.Drawing.Point(876, 91);
            this.CloseHrsMskTxB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CloseHrsMskTxB.Mask = "00:00";
            this.CloseHrsMskTxB.Name = "CloseHrsMskTxB";
            this.CloseHrsMskTxB.Size = new System.Drawing.Size(289, 38);
            this.CloseHrsMskTxB.TabIndex = 11;
            this.CloseHrsMskTxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseHrsMskTxB.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "(XX:00)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1177, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "(XX:00)";
            // 
            // LocationTexB
            // 
            this.LocationTexB.Location = new System.Drawing.Point(255, 141);
            this.LocationTexB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LocationTexB.Name = "LocationTexB";
            this.LocationTexB.Size = new System.Drawing.Size(1033, 38);
            this.LocationTexB.TabIndex = 14;
            // 
            // DescriptionTexB
            // 
            this.DescriptionTexB.Location = new System.Drawing.Point(255, 198);
            this.DescriptionTexB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DescriptionTexB.Multiline = true;
            this.DescriptionTexB.Name = "DescriptionTexB";
            this.DescriptionTexB.Size = new System.Drawing.Size(1033, 380);
            this.DescriptionTexB.TabIndex = 15;
            // 
            // AddFacilityButton
            // 
            this.AddFacilityButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddFacilityButton.Location = new System.Drawing.Point(485, 637);
            this.AddFacilityButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddFacilityButton.Name = "AddFacilityButton";
            this.AddFacilityButton.Size = new System.Drawing.Size(236, 48);
            this.AddFacilityButton.TabIndex = 16;
            this.AddFacilityButton.Text = "Add Facility";
            this.AddFacilityButton.UseVisualStyleBackColor = true;
            this.AddFacilityButton.Click += new System.EventHandler(this.AddFacilityButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(733, 637);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(150, 48);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CreateFacility
            // 
            this.AcceptButton = this.AddFacilityButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(1360, 735);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddFacilityButton);
            this.Controls.Add(this.DescriptionTexB);
            this.Controls.Add(this.LocationTexB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CloseHrsMskTxB);
            this.Controls.Add(this.OpenHrsMskTxB);
            this.Controls.Add(this.FacilityTypeComB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacilityNameTxtB);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateFacility";
            this.Text = "Create Facility";
            this.Load += new System.EventHandler(this.CreatFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FacilityNameTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FacilityTypeComB;
        private System.Windows.Forms.MaskedTextBox OpenHrsMskTxB;
        private System.Windows.Forms.MaskedTextBox CloseHrsMskTxB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LocationTexB;
        private System.Windows.Forms.TextBox DescriptionTexB;
        private System.Windows.Forms.Button AddFacilityButton;
        private System.Windows.Forms.Button CloseButton;
    }
}