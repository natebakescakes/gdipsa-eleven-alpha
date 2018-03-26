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
        
        int selectedIndex;
        MembersTab memberTab;


        public EditMember()
        {
            InitializeComponent();
            
            ctx = new ElevenAlphaEntities();
        }

        public EditMember(int memberId,int selectedIndex,MembersTab memberTab)
        {
            InitializeComponent();
            this.memberId = memberId;
            this.selectedIndex = selectedIndex;
            this.memberTab = memberTab;
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

            
            Regex isValidEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-z]*\.)+[a-zA-Z0-9][\-a-zA-Z0-9]{0,22}[a-zA-Z0-9]))$");

            if (FirstNameTxtBox.Text == "")
            {
                MessageBox.Show("Please input First Name.");
            }

            else if (GenderComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please input Gender.");
            }
            else if (MobileTextBox.MaskedTextProvider.AssignedEditPositionCount < 8)
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
            else if (EmergencyNumberTextBox.MaskedTextProvider.AssignedEditPositionCount < 8)
            {
                MessageBox.Show("Please input a valid Emergency Contact Number.");
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

                if (memberTab.SearchTextBox.Text != "")
                {
                    if (memberTab.HideInactiveCheckbox.Checked == true)
                    {
                        memberTab.SearchActiveMembers();
                    }
                    else
                    {
                        memberTab.SearchAllMembers();
                    }

                }

                else
                {
                    if (memberTab.HideInactiveCheckbox.Checked == true)
                    {
                        memberTab.ViewActiveMembers();
                    }
                    else
                    {
                        memberTab.ViewAllMembers();
                    }

                }

                memberTab.MemberInfoTable.Rows[selectedIndex].Selected = true;
                    this.Close();
                }
            }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            memberTab.MemberInfoTable.Refresh();
            this.Close();
            
        }
    }
}
