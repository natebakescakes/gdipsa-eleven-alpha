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
    public partial class AddNewMember : Form
    {
        ElevenAlphaEntities ctx = new ElevenAlphaEntities();
        public AddNewMember()
        {
            InitializeComponent();
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            Regex isValidNumber = new Regex(@"\+\d{2}-?\d{4}-?\d{4}$");
            Regex isValidEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            if (FirstNameTxtBox.Text == "")
            {
                MessageBox.Show("Please enter First Name!");
            }
           
            else if (GenderComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please input gender!");
            }
            else if ((MobileTextBox.Text == "") || !isValidNumber.IsMatch(MobileTextBox.Text))
            {
                MessageBox.Show("Please input valid Mobile number!");
            }
            
            else if (EmailTextBox.Text == "" || !isValidEmail.IsMatch(EmailTextBox.Text))
            {
                MessageBox.Show("Please input valid email!");
            }
           
            else if (EmergencyNameTextBox.Text == "")
            {
                MessageBox.Show("Please input emergency contact name!");
            }
            else if (EmergencyNumberTextBox.Text == "" || !isValidNumber.IsMatch(MobileTextBox.Text))
            {
                MessageBox.Show("Please input emergency contact number!");
            }
            else
            {
                
                Member newMember = new Member();

                newMember.FirstName = FirstNameTxtBox.Text;
                newMember.LastName = LNameTextBox.Text;
                newMember.Email = EmailTextBox.Text;
                newMember.DateOfBirth = DOBPicker.Value;
                newMember.Active = 1;
                newMember.Mobile = MobileTextBox.Text;
                newMember.EmergencyContact = EmergencyNumberTextBox.Text;
                newMember.EmergencyName = EmergencyNameTextBox.Text;
                newMember.EmergencyRelation = MemberRelationTextBox.Text;
                
                if (SalutationComboBox.SelectedItem == null)
                {
                    newMember.Salutations = "";
                }
                else
                {
                    newMember.Salutations = SalutationComboBox.SelectedItem.ToString();
                }

                if (GenderComboBox.SelectedItem.ToString() == "Male")
                {
                    newMember.Gender = "M";
                }
                else
                {
                    newMember.Gender = "F";
                }

                ctx.Members.Add(newMember);
                ctx.SaveChanges();


                MessageBox.Show(String.Format("New member {0} {1} with Member ID: {2} has been added!",newMember.FirstName,newMember.LastName, newMember.MemberID));

            }

           


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
