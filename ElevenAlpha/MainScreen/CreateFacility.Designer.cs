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
            this.FacilityNameTxtB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacilityNameTxtB.Location = new System.Drawing.Point(180, 59);
            this.FacilityNameTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FacilityNameTxtB.Name = "FacilityNameTxtB";
            this.FacilityNameTxtB.Size = new System.Drawing.Size(229, 26);
            this.FacilityNameTxtB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facility Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opening Time";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Facility Type";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Closing Time";
            // 
            // FacilityTypeComB
            // 
            this.FacilityTypeComB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacilityTypeComB.FormattingEnabled = true;
            this.FacilityTypeComB.Location = new System.Drawing.Point(530, 59);
            this.FacilityTypeComB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FacilityTypeComB.Name = "FacilityTypeComB";
            this.FacilityTypeComB.Size = new System.Drawing.Size(234, 28);
            this.FacilityTypeComB.TabIndex = 9;
            this.FacilityTypeComB.SelectedIndexChanged += new System.EventHandler(this.FacilityTypeComB_SelectedIndexChanged);
            // 
            // OpenHrsMskTxB
            // 
            this.OpenHrsMskTxB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenHrsMskTxB.Location = new System.Drawing.Point(180, 92);
            this.OpenHrsMskTxB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenHrsMskTxB.Mask = "00:00";
            this.OpenHrsMskTxB.Name = "OpenHrsMskTxB";
            this.OpenHrsMskTxB.ReadOnly = true;
            this.OpenHrsMskTxB.Size = new System.Drawing.Size(159, 26);
            this.OpenHrsMskTxB.TabIndex = 10;
            this.OpenHrsMskTxB.Text = "0800";
            this.OpenHrsMskTxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpenHrsMskTxB.ValidatingType = typeof(System.DateTime);
            this.OpenHrsMskTxB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.OpenHrsMskTxB_MaskInputRejected);
            // 
            // CloseHrsMskTxB
            // 
            this.CloseHrsMskTxB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseHrsMskTxB.Location = new System.Drawing.Point(530, 92);
            this.CloseHrsMskTxB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseHrsMskTxB.Mask = "00:00";
            this.CloseHrsMskTxB.Name = "CloseHrsMskTxB";
            this.CloseHrsMskTxB.ReadOnly = true;
            this.CloseHrsMskTxB.Size = new System.Drawing.Size(163, 26);
            this.CloseHrsMskTxB.TabIndex = 11;
            this.CloseHrsMskTxB.Text = "2000";
            this.CloseHrsMskTxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseHrsMskTxB.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "(XX:00)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(699, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "(XX:00)";
            // 
            // LocationTexB
            // 
            this.LocationTexB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationTexB.Location = new System.Drawing.Point(180, 124);
            this.LocationTexB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LocationTexB.Name = "LocationTexB";
            this.LocationTexB.Size = new System.Drawing.Size(583, 26);
            this.LocationTexB.TabIndex = 14;
            // 
            // DescriptionTexB
            // 
            this.DescriptionTexB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTexB.Location = new System.Drawing.Point(180, 161);
            this.DescriptionTexB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionTexB.Multiline = true;
            this.DescriptionTexB.Name = "DescriptionTexB";
            this.DescriptionTexB.Size = new System.Drawing.Size(583, 247);
            this.DescriptionTexB.TabIndex = 15;
            // 
            // AddFacilityButton
            // 
            this.AddFacilityButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFacilityButton.Location = new System.Drawing.Point(310, 444);
            this.AddFacilityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddFacilityButton.Name = "AddFacilityButton";
            this.AddFacilityButton.Size = new System.Drawing.Size(133, 31);
            this.AddFacilityButton.TabIndex = 16;
            this.AddFacilityButton.Text = "Add Facility";
            this.AddFacilityButton.UseVisualStyleBackColor = true;
            this.AddFacilityButton.Click += new System.EventHandler(this.AddFacilityButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(449, 444);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(84, 31);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CreateFacility
            // 
            this.AcceptButton = this.AddFacilityButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(839, 540);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateFacility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Facility";
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