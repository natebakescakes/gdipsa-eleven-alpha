﻿namespace ElevenAlpha
{
    partial class AddNewMember
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
            this.components = new System.ComponentModel.Container();
            this.SalutationComboBox = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.MobileNumber = new System.Windows.Forms.Label();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.Email = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmergencyContact = new System.Windows.Forms.GroupBox();
            this.MemberRelationTextBox = new System.Windows.Forms.TextBox();
            this.EmergencyNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmergencyNameTextBox = new System.Windows.Forms.TextBox();
            this.MemberRelationship = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.ContactName = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EmergencyContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalutationComboBox
            // 
            this.SalutationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SalutationComboBox.FormattingEnabled = true;
            this.SalutationComboBox.Items.AddRange(new object[] {
            "",
            "Mr",
            "Ms",
            "Mrs",
            "Mdm",
            "Dr"});
            this.SalutationComboBox.Location = new System.Drawing.Point(30, 29);
            this.SalutationComboBox.Name = "SalutationComboBox";
            this.SalutationComboBox.Size = new System.Drawing.Size(64, 28);
            this.SalutationComboBox.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(110, 33);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(86, 20);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            //this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(445, 34);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(86, 20);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Last Name";
            //this.LastName.Click += new System.EventHandler(this.LastName_Click);
            // 
            // DOB
            // 
            this.DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(24, 92);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(102, 20);
            this.DOB.TabIndex = 4;
            this.DOB.Text = "Date Of Birth";
            //this.DOB.Click += new System.EventHandler(this.DOB_Click);
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(463, 92);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 20);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Gender";
            //this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // MobileNumber
            // 
            this.MobileNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MobileNumber.AutoSize = true;
            this.MobileNumber.Location = new System.Drawing.Point(24, 143);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(115, 20);
            this.MobileNumber.TabIndex = 6;
            this.MobileNumber.Text = "Mobile Number";
            //this.MobileNumber.Click += new System.EventHandler(this.MobileNumber_Click);
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LNameTextBox.Location = new System.Drawing.Point(533, 32);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(237, 26);
            this.LNameTextBox.TabIndex = 7;
            // 
            // DOBPicker
            // 
            this.DOBPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DOBPicker.Location = new System.Drawing.Point(132, 89);
            this.DOBPicker.MaxDate = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(307, 26);
            this.DOBPicker.TabIndex = 8;
            this.DOBPicker.Value = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MobileTextBox.Location = new System.Drawing.Point(143, 143);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(187, 26);
            this.MobileTextBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.MobileTextBox, "Mobile Number Format: +65-0000-0000");
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(532, 87);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(100, 28);
            this.GenderComboBox.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(337, 146);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(111, 20);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email Address";
            //this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EmailTextBox.Location = new System.Drawing.Point(453, 143);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(316, 26);
            this.EmailTextBox.TabIndex = 12;
            // 
            // EmergencyContact
            // 
            this.EmergencyContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EmergencyContact.Controls.Add(this.MemberRelationTextBox);
            this.EmergencyContact.Controls.Add(this.EmergencyNumberTextBox);
            this.EmergencyContact.Controls.Add(this.EmergencyNameTextBox);
            this.EmergencyContact.Controls.Add(this.MemberRelationship);
            this.EmergencyContact.Controls.Add(this.ContactNumber);
            this.EmergencyContact.Controls.Add(this.ContactName);
            this.EmergencyContact.Location = new System.Drawing.Point(28, 199);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(741, 172);
            this.EmergencyContact.TabIndex = 13;
            this.EmergencyContact.TabStop = false;
            this.EmergencyContact.Text = "Emergency Contact Details";
            //this.EmergencyContact.Enter += new System.EventHandler(this.EmergencyContact_Enter);
            // 
            // MemberRelationTextBox
            // 
            this.MemberRelationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MemberRelationTextBox.Location = new System.Drawing.Point(221, 112);
            this.MemberRelationTextBox.Name = "MemberRelationTextBox";
            this.MemberRelationTextBox.Size = new System.Drawing.Size(237, 26);
            this.MemberRelationTextBox.TabIndex = 12;
            // 
            // EmergencyNumberTextBox
            // 
            this.EmergencyNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EmergencyNumberTextBox.Location = new System.Drawing.Point(221, 80);
            this.EmergencyNumberTextBox.Name = "EmergencyNumberTextBox";
            this.EmergencyNumberTextBox.Size = new System.Drawing.Size(237, 26);
            this.EmergencyNumberTextBox.TabIndex = 11;
            // 
            // EmergencyNameTextBox
            // 
            this.EmergencyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EmergencyNameTextBox.Location = new System.Drawing.Point(221, 48);
            this.EmergencyNameTextBox.Name = "EmergencyNameTextBox";
            this.EmergencyNameTextBox.Size = new System.Drawing.Size(237, 26);
            this.EmergencyNameTextBox.TabIndex = 10;
            // 
            // MemberRelationship
            // 
            this.MemberRelationship.AutoSize = true;
            this.MemberRelationship.Location = new System.Drawing.Point(33, 115);
            this.MemberRelationship.Name = "MemberRelationship";
            this.MemberRelationship.Size = new System.Drawing.Size(177, 20);
            this.MemberRelationship.TabIndex = 5;
            this.MemberRelationship.Text = "Relationship to Member";
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.Location = new System.Drawing.Point(33, 83);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(125, 20);
            this.ContactNumber.TabIndex = 4;
            this.ContactNumber.Text = "Contact Number";
            // 
            // ContactName
            // 
            this.ContactName.AutoSize = true;
            this.ContactName.Location = new System.Drawing.Point(33, 48);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(111, 20);
            this.ContactName.TabIndex = 2;
            this.ContactName.Text = "Contact Name";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(200, 30);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(237, 26);
            this.FirstNameTxtBox.TabIndex = 9;
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Location = new System.Drawing.Point(275, 388);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(114, 34);
            this.AddMemberButton.TabIndex = 14;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(406, 388);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 34);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel ";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // AddNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.EmergencyContact);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.LNameTextBox);
            this.Controls.Add(this.MobileNumber);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SalutationComboBox);
            this.Name = "AddNewMember";
            this.Text = "AddNewMember";
            this.EmergencyContact.ResumeLayout(false);
            this.EmergencyContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SalutationComboBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label MobileNumber;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.GroupBox EmergencyContact;
        private System.Windows.Forms.Label MemberRelationship;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label ContactName;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox MemberRelationTextBox;
        private System.Windows.Forms.TextBox EmergencyNumberTextBox;
        private System.Windows.Forms.TextBox EmergencyNameTextBox;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}