﻿namespace ElevenAlpha
{
    partial class EditMember
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpdateMemberButton = new System.Windows.Forms.Button();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.EmergencyContact = new System.Windows.Forms.GroupBox();
            this.MemberRelationTextBox = new System.Windows.Forms.TextBox();
            this.EmergencyNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmergencyNameTextBox = new System.Windows.Forms.TextBox();
            this.MemberRelationship = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.ContactName = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.MobileNumber = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.SalutationComboBox = new System.Windows.Forms.ComboBox();
            this.EmergencyContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.Location = new System.Drawing.Point(656, 491);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(142, 53);
            this.CloseButton.TabIndex = 31;
            this.CloseButton.Text = "Cancel ";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UpdateMemberButton
            // 
            this.UpdateMemberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateMemberButton.Location = new System.Drawing.Point(390, 491);
            this.UpdateMemberButton.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateMemberButton.Name = "UpdateMemberButton";
            this.UpdateMemberButton.Size = new System.Drawing.Size(236, 53);
            this.UpdateMemberButton.TabIndex = 30;
            this.UpdateMemberButton.Text = "Update Member";
            this.UpdateMemberButton.UseVisualStyleBackColor = true;
            this.UpdateMemberButton.Click += new System.EventHandler(this.UpdateMemberButton_Click);
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameTxtBox.Location = new System.Drawing.Point(340, 46);
            this.FirstNameTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(311, 38);
            this.FirstNameTxtBox.TabIndex = 1;
            // 
            // EmergencyContact
            // 
            this.EmergencyContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmergencyContact.Controls.Add(this.MemberRelationTextBox);
            this.EmergencyContact.Controls.Add(this.EmergencyNumberTextBox);
            this.EmergencyContact.Controls.Add(this.EmergencyNameTextBox);
            this.EmergencyContact.Controls.Add(this.MemberRelationship);
            this.EmergencyContact.Controls.Add(this.ContactNumber);
            this.EmergencyContact.Controls.Add(this.ContactName);
            this.EmergencyContact.Location = new System.Drawing.Point(57, 194);
            this.EmergencyContact.Margin = new System.Windows.Forms.Padding(5);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Padding = new System.Windows.Forms.Padding(5);
            this.EmergencyContact.Size = new System.Drawing.Size(1076, 267);
            this.EmergencyContact.TabIndex = 29;
            this.EmergencyContact.TabStop = false;
            this.EmergencyContact.Text = "Emergency Contact Details";
            // 
            // MemberRelationTextBox
            // 
            this.MemberRelationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberRelationTextBox.Location = new System.Drawing.Point(384, 175);
            this.MemberRelationTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MemberRelationTextBox.Name = "MemberRelationTextBox";
            this.MemberRelationTextBox.Size = new System.Drawing.Size(418, 38);
            this.MemberRelationTextBox.TabIndex = 9;
            // 
            // EmergencyNumberTextBox
            // 
            this.EmergencyNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmergencyNumberTextBox.Location = new System.Drawing.Point(384, 125);
            this.EmergencyNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EmergencyNumberTextBox.Name = "EmergencyNumberTextBox";
            this.EmergencyNumberTextBox.Size = new System.Drawing.Size(418, 38);
            this.EmergencyNumberTextBox.TabIndex = 8;
            // 
            // EmergencyNameTextBox
            // 
            this.EmergencyNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmergencyNameTextBox.Location = new System.Drawing.Point(384, 75);
            this.EmergencyNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EmergencyNameTextBox.Name = "EmergencyNameTextBox";
            this.EmergencyNameTextBox.Size = new System.Drawing.Size(418, 38);
            this.EmergencyNameTextBox.TabIndex = 7;
            // 
            // MemberRelationship
            // 
            this.MemberRelationship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberRelationship.AutoSize = true;
            this.MemberRelationship.Location = new System.Drawing.Point(59, 178);
            this.MemberRelationship.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MemberRelationship.Name = "MemberRelationship";
            this.MemberRelationship.Size = new System.Drawing.Size(315, 32);
            this.MemberRelationship.TabIndex = 5;
            this.MemberRelationship.Text = "Relationship to Member";
            // 
            // ContactNumber
            // 
            this.ContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.Location = new System.Drawing.Point(59, 129);
            this.ContactNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(220, 32);
            this.ContactNumber.TabIndex = 4;
            this.ContactNumber.Text = "Contact Number";
            // 
            // ContactName
            // 
            this.ContactName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactName.AutoSize = true;
            this.ContactName.Location = new System.Drawing.Point(59, 74);
            this.ContactName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(195, 32);
            this.ContactName.TabIndex = 2;
            this.ContactName.Text = "Contact Name";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTextBox.Location = new System.Drawing.Point(725, 146);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(408, 38);
            this.EmailTextBox.TabIndex = 6;
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(517, 149);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(198, 32);
            this.Email.TabIndex = 27;
            this.Email.Text = "Email Address";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(980, 98);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(153, 39);
            this.GenderComboBox.TabIndex = 4;
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MobileTextBox.Location = new System.Drawing.Point(268, 143);
            this.MobileTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(239, 38);
            this.MobileTextBox.TabIndex = 5;
            // 
            // DOBPicker
            // 
            this.DOBPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DOBPicker.Location = new System.Drawing.Point(239, 95);
            this.DOBPicker.Margin = new System.Windows.Forms.Padding(5);
            this.DOBPicker.MaxDate = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(611, 38);
            this.DOBPicker.TabIndex = 3;
            this.DOBPicker.Value = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNameTextBox.Location = new System.Drawing.Point(822, 46);
            this.LNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(311, 38);
            this.LNameTextBox.TabIndex = 2;
            // 
            // MobileNumber
            // 
            this.MobileNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MobileNumber.AutoSize = true;
            this.MobileNumber.Location = new System.Drawing.Point(51, 146);
            this.MobileNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(207, 32);
            this.MobileNumber.TabIndex = 21;
            this.MobileNumber.Text = "Mobile Number";
            // 
            // Gender
            // 
            this.Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(860, 101);
            this.Gender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(110, 32);
            this.Gender.TabIndex = 20;
            this.Gender.Text = "Gender";
            // 
            // DOB
            // 
            this.DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(51, 101);
            this.DOB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(178, 32);
            this.DOB.TabIndex = 19;
            this.DOB.Text = "Date Of Birth";
            // 
            // LastName
            // 
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(661, 48);
            this.LastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(151, 32);
            this.LastName.TabIndex = 18;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(178, 50);
            this.FirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(152, 32);
            this.FirstName.TabIndex = 17;
            this.FirstName.Text = "First Name";
            // 
            // SalutationComboBox
            // 
            this.SalutationComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalutationComboBox.FormattingEnabled = true;
            this.SalutationComboBox.Items.AddRange(new object[] {
            "",
            "Mr",
            "Ms",
            "Mrs",
            "Mdm",
            "Dr"});
            this.SalutationComboBox.Location = new System.Drawing.Point(59, 45);
            this.SalutationComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.SalutationComboBox.Name = "SalutationComboBox";
            this.SalutationComboBox.Size = new System.Drawing.Size(111, 39);
            this.SalutationComboBox.TabIndex = 0;
            // 
            // EditMember
            // 
            this.AcceptButton = this.UpdateMemberButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(1199, 587);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UpdateMemberButton);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditMember";
            this.Text = "Edit Member";
            this.Load += new System.EventHandler(this.EditMember_Load);
            this.EmergencyContact.ResumeLayout(false);
            this.EmergencyContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button UpdateMemberButton;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.GroupBox EmergencyContact;
        private System.Windows.Forms.TextBox MemberRelationTextBox;
        private System.Windows.Forms.TextBox EmergencyNumberTextBox;
        private System.Windows.Forms.TextBox EmergencyNameTextBox;
        private System.Windows.Forms.Label MemberRelationship;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label ContactName;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.Label MobileNumber;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.ComboBox SalutationComboBox;
    }
}