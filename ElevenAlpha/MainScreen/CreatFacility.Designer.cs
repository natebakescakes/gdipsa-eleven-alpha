namespace ElevenAlpha
{
    partial class CreatFacility
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
            this.InputNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FacilityTypeComB = new System.Windows.Forms.ComboBox();
            this.OpenHrsMskTxB = new System.Windows.Forms.MaskedTextBox();
            this.CloseHrsTexB = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LocationTexB = new System.Windows.Forms.TextBox();
            this.DescriptionTexB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputNameTextBox
            // 
            this.InputNameTextBox.Location = new System.Drawing.Point(184, 33);
            this.InputNameTextBox.Name = "InputNameTextBox";
            this.InputNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.InputNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faclity Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opening Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Facility Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Closing Hours";
            // 
            // FacilityTypeComB
            // 
            this.FacilityTypeComB.FormattingEnabled = true;
            this.FacilityTypeComB.Location = new System.Drawing.Point(529, 33);
            this.FacilityTypeComB.Name = "FacilityTypeComB";
            this.FacilityTypeComB.Size = new System.Drawing.Size(121, 23);
            this.FacilityTypeComB.TabIndex = 9;
            // 
            // OpenHrsMskTxB
            // 
            this.OpenHrsMskTxB.Location = new System.Drawing.Point(184, 111);
            this.OpenHrsMskTxB.Mask = "00:00";
            this.OpenHrsMskTxB.Name = "OpenHrsMskTxB";
            this.OpenHrsMskTxB.Size = new System.Drawing.Size(100, 25);
            this.OpenHrsMskTxB.TabIndex = 10;
            this.OpenHrsMskTxB.ValidatingType = typeof(System.DateTime);
            // 
            // CloseHrsTexB
            // 
            this.CloseHrsTexB.Location = new System.Drawing.Point(529, 111);
            this.CloseHrsTexB.Mask = "00:00";
            this.CloseHrsTexB.Name = "CloseHrsTexB";
            this.CloseHrsTexB.Size = new System.Drawing.Size(100, 25);
            this.CloseHrsTexB.TabIndex = 11;
            this.CloseHrsTexB.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "(xx:00)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(655, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "(xx:00)";
            // 
            // LocationTexB
            // 
            this.LocationTexB.Location = new System.Drawing.Point(184, 175);
            this.LocationTexB.Name = "LocationTexB";
            this.LocationTexB.Size = new System.Drawing.Size(100, 25);
            this.LocationTexB.TabIndex = 14;
            // 
            // DescriptionTexB
            // 
            this.DescriptionTexB.Location = new System.Drawing.Point(184, 243);
            this.DescriptionTexB.Multiline = true;
            this.DescriptionTexB.Name = "DescriptionTexB";
            this.DescriptionTexB.Size = new System.Drawing.Size(434, 150);
            this.DescriptionTexB.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Facility";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CreatFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DescriptionTexB);
            this.Controls.Add(this.LocationTexB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CloseHrsTexB);
            this.Controls.Add(this.OpenHrsMskTxB);
            this.Controls.Add(this.FacilityTypeComB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputNameTextBox);
            this.Name = "CreatFacility";
            this.Text = "CreatFacility";
            this.Load += new System.EventHandler(this.CreatFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FacilityTypeComB;
        private System.Windows.Forms.MaskedTextBox OpenHrsMskTxB;
        private System.Windows.Forms.MaskedTextBox CloseHrsTexB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LocationTexB;
        private System.Windows.Forms.TextBox DescriptionTexB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}