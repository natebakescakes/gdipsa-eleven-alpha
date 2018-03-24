namespace ElevenAlpha
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
            this.CancelButton = new System.Windows.Forms.Button();
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
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(409, 388);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 34);
            this.CancelButton.TabIndex = 31;
            this.CancelButton.Text = "Cancel ";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UpdateMemberButton
            // 
            this.UpdateMemberButton.Location = new System.Drawing.Point(278, 388);
            this.UpdateMemberButton.Name = "UpdateMemberButton";
            this.UpdateMemberButton.Size = new System.Drawing.Size(114, 34);
            this.UpdateMemberButton.TabIndex = 30;
            this.UpdateMemberButton.Text = "Update";
            this.UpdateMemberButton.UseVisualStyleBackColor = true;
            this.UpdateMemberButton.Click += new System.EventHandler(this.UpdateMemberButton_Click);
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(203, 30);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(237, 26);
            this.FirstNameTxtBox.TabIndex = 24;
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
            this.EmergencyContact.Location = new System.Drawing.Point(31, 199);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(741, 172);
            this.EmergencyContact.TabIndex = 29;
            this.EmergencyContact.TabStop = false;
            this.EmergencyContact.Text = "Emergency Contact Details";
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
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EmailTextBox.Location = new System.Drawing.Point(456, 143);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(316, 26);
            this.EmailTextBox.TabIndex = 28;
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(340, 146);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(111, 20);
            this.Email.TabIndex = 27;
            this.Email.Text = "Email Address";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(535, 87);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(100, 28);
            this.GenderComboBox.TabIndex = 26;
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MobileTextBox.Location = new System.Drawing.Point(146, 143);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(187, 26);
            this.MobileTextBox.TabIndex = 25;
            // 
            // DOBPicker
            // 
            this.DOBPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DOBPicker.Location = new System.Drawing.Point(135, 89);
            this.DOBPicker.MaxDate = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(307, 26);
            this.DOBPicker.TabIndex = 23;
            this.DOBPicker.Value = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LNameTextBox.Location = new System.Drawing.Point(536, 32);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(237, 26);
            this.LNameTextBox.TabIndex = 22;
            // 
            // MobileNumber
            // 
            this.MobileNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MobileNumber.AutoSize = true;
            this.MobileNumber.Location = new System.Drawing.Point(27, 143);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(115, 20);
            this.MobileNumber.TabIndex = 21;
            this.MobileNumber.Text = "Mobile Number";
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(466, 92);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 20);
            this.Gender.TabIndex = 20;
            this.Gender.Text = "Gender";
            // 
            // DOB
            // 
            this.DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(27, 92);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(102, 20);
            this.DOB.TabIndex = 19;
            this.DOB.Text = "Date Of Birth";
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(448, 34);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(86, 20);
            this.LastName.TabIndex = 18;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(113, 33);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(86, 20);
            this.FirstName.TabIndex = 17;
            this.FirstName.Text = "First Name";
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
            this.SalutationComboBox.Location = new System.Drawing.Point(33, 29);
            this.SalutationComboBox.Name = "SalutationComboBox";
            this.SalutationComboBox.Size = new System.Drawing.Size(64, 28);
            this.SalutationComboBox.TabIndex = 16;
            // 
            // EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
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
            this.Name = "EditMember";
            this.Text = "Edit Member";
            this.Load += new System.EventHandler(this.EditMember_Load);
            this.EmergencyContact.ResumeLayout(false);
            this.EmergencyContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
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