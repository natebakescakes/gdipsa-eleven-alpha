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
    public partial class CreateMember : Form
    {
        ElevenAlphaEntities ctx = new ElevenAlphaEntities();
        private int flag = 0;
        MembersTab memberTab;
        public CreateMember(MembersTab memberTab)
        {
            InitializeComponent();
            this.memberTab = memberTab;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            
            Regex isValidEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9A-Za-z][-\w]*[0-9A-Za-z]*\.)+[a-zA-Z0-9][\-a-zA-Z0-9]{0,22}[a-zA-Z0-9]))$");

            if (FirstNameTxtBox.Text == "")
            {
                MessageBox.Show("Please input a First Name.");
            }

            else if (GenderComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please input Gender.");
            }
            else if(MobileTextBox.MaskedTextProvider.AssignedEditPositionCount <8)
            {
                MessageBox.Show("Please input a valid Mobile number.");
            }

            else if (EmailTextBox.Text == "" || !isValidEmail.IsMatch(EmailTextBox.Text))
            {
                MessageBox.Show("Please input a valid Email Address.");
            }

            else if (EmergencyNameTextBox.Text == "")
            {
                MessageBox.Show("Please input an Emergency Contact Name.");
            }
            else if (EmergencyNumberTextBox.MaskedTextProvider.AssignedEditPositionCount <8 )
            {
                MessageBox.Show("Please input a valid Emergency Contact Number.");
            }
            else
            {
                foreach (Member m in ctx.Members)
                {
                    if ((m.FirstName == FirstNameTxtBox.Text) && (m.LastName == LNameTextBox.Text) && (m.DateOfBirth == DOBPicker.Value) && (m.Email == EmailTextBox.Text))
                    {
                        MessageBox.Show("Member already exists!");
                        flag = 1;
                        break;

                    }

                    this.Close();
                }
                if (flag == 0)
                {
                    
                    flag = 0;

                    Member newMember = new Member
                    {
                        FirstName = FirstNameTxtBox.Text,
                        LastName = LNameTextBox.Text,
                        Email = EmailTextBox.Text,
                        DateOfBirth = DOBPicker.Value,
                        Active = 1,
                        Mobile = MobileTextBox.Text,
                        EmergencyContact = EmergencyNumberTextBox.Text,
                        EmergencyName = EmergencyNameTextBox.Text,
                        EmergencyRelation = MemberRelationTextBox.Text
                    };

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


                    MessageBox.Show(String.Format("New member {0} {1} with Member ID: {2} has been added!", newMember.FirstName, newMember.LastName, newMember.MemberID));
                    
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


                    int selectedIndex = memberTab.MemberInfoTable.Rows.Count - 1;

                    memberTab.MemberInfoTable.Rows[selectedIndex].Selected = true;
                    memberTab.MemberInfoTable.FirstDisplayedScrollingRowIndex = selectedIndex;
                    this.Close();
                }


            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
            memberTab.MemberInfoTable.Refresh();
            this.Close();
        }
    }
}
