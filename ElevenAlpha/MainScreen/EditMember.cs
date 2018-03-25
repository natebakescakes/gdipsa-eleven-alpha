using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ElevenAlpha
{
    public partial class EditMember : Form
    {
        private int memberId;
        ElevenAlphaEntities ctx;
        
        public EditMember()
        {
            InitializeComponent();
            memberId = 6;
            ctx = new ElevenAlphaEntities();
        }

        public EditMember(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            ctx = new ElevenAlphaEntities();
        }


        private void EditMember_Load(object sender, EventArgs e)
        {
            Member memberToEdit = (Member)(from x in ctx.Members where x.MemberID == memberId select x).First();
            FirstNameTxtBox.Text = memberToEdit.FirstName;
            LNameTextBox.Text = memberToEdit.LastName;
            EmailTextBox.Text = memberToEdit.Email;
            DOBPicker.Value = memberToEdit.DateOfBirth;
            MobileTextBox.Text = memberToEdit.Mobile;
            EmergencyNumberTextBox.Text = memberToEdit.EmergencyContact;
            EmergencyNameTextBox.Text = memberToEdit.EmergencyName;
            MemberRelationTextBox.Text = memberToEdit.EmergencyRelation;

            if (memberToEdit.Gender == "M")
            {
                GenderComboBox.SelectedItem = "Male";
            }
            else
            {
                GenderComboBox.SelectedItem = "Female";
            }

            if (memberToEdit.Salutations == null)
            {
                SalutationComboBox.SelectedItem = "";
            }
            else
            {
                SalutationComboBox.SelectedItem=memberToEdit.Salutations;
            }
        }


        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {

            Regex isValidNumber = new Regex(@"\+\d{2}-?\d{4}-?\d{4}$");
            Regex isValidEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            if (FirstNameTxtBox.Text == "")
            {
                MessageBox.Show("Please input First Name.");
            }

            else if (GenderComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please input Gender.");
            }
            else if ((MobileTextBox.Text == "") || !isValidNumber.IsMatch(MobileTextBox.Text))
            {
                MessageBox.Show("Please input a valid Mobile Number.");
            }

            else if (EmailTextBox.Text == "" || !isValidEmail.IsMatch(EmailTextBox.Text))
            {
                MessageBox.Show("Please input a valid Email Address.");
            }

            else if (EmergencyNameTextBox.Text == "")
            {
                MessageBox.Show("Please input an Emergency Contact Name.");
            }
            else if (EmergencyNumberTextBox.Text == "" || !isValidNumber.IsMatch(MobileTextBox.Text))
            {
                MessageBox.Show("Please input an Emergency Contact Number.");
            }
            else
            {
                Member memberToEdit = (Member)(from x in ctx.Members where x.MemberID == memberId select x).First();

                memberToEdit.FirstName = FirstNameTxtBox.Text;
                memberToEdit.LastName = LNameTextBox.Text;
                memberToEdit.Email = EmailTextBox.Text;
                memberToEdit.DateOfBirth = DOBPicker.Value;
                memberToEdit.Mobile = MobileTextBox.Text;
                memberToEdit.EmergencyContact = EmergencyNumberTextBox.Text;
                memberToEdit.EmergencyName = EmergencyNameTextBox.Text;
                memberToEdit.EmergencyRelation = MemberRelationTextBox.Text;

                if (SalutationComboBox.SelectedItem == null)
                {
                    memberToEdit.Salutations = "";
                }
                else
                {
                    memberToEdit.Salutations = SalutationComboBox.SelectedItem.ToString();
                }

                if (GenderComboBox.SelectedItem.ToString() == "Male")
                {
                    memberToEdit.Gender = "M";
                }
                else
                {
                    memberToEdit.Gender = "F";
                }

                ctx.SaveChanges();
                MessageBox.Show(String.Format("The details of {0} {1} with Member ID: {2} has been updated!", memberToEdit.FirstName, memberToEdit.LastName, memberToEdit.MemberID));

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
