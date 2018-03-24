using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevenAlpha
{
    public partial class members_tab : UserControl
    {
        ElevenAlphaEntities ctx= new ElevenAlphaEntities();
        
        public members_tab()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           
        }
        private void members_tab_Load(object sender, EventArgs e)
        {
            ViewActiveMembers();  
        }


        private void ViewAllMembers()
        {
            MemberInfoTable.DataSource = ctx.Members
              .Select(x => new { x.MemberID, x.FirstName, x.LastName, x.Gender, x.Mobile, x.Email, x.EmergencyContact, Active = x.Active == 1 ? "Active" : "Discontinued" }).ToList();
            SetColumnHeader();
        }

        private void ViewActiveMembers()
        {
            MemberInfoTable.DataSource = ctx.Members.Where(x => x.Active == 1)
              .Select(x => new { x.MemberID, x.FirstName, x.LastName, x.Gender, x.Mobile, x.Email, x.EmergencyContact, Active = x.Active == 1 ? "Active" : "Discontinued" }).ToList();
            SetColumnHeader();
            //if(MemberInfoTable.)
        }

        private void SetColumnHeader()
        {
            MemberInfoTable.Columns[0].HeaderText = "Member ID";
            MemberInfoTable.Columns[1].HeaderText = "First Name";
            MemberInfoTable.Columns[2].HeaderText = "Last Name";
            MemberInfoTable.Columns[3].HeaderText = "Gender";
            MemberInfoTable.Columns[4].HeaderText = "Contact Number";
            MemberInfoTable.Columns[5].HeaderText = "Email Address";
            MemberInfoTable.Columns[6].HeaderText = "Emergency Contact Number";
            MemberInfoTable.Columns[7].HeaderText = "Member Status";
        }

        private void SearchAllMembers()
        {
            string searchValue = SearchTextBox.Text.ToString();
            int searchValueLength = searchValue.Length;
            var q = from x in ctx.Members
                    where x.FirstName.Substring(0, searchValueLength) == searchValue ||
                    x.LastName.Substring(0, searchValueLength) == searchValue ||
                    x.Mobile.Substring(4, searchValueLength) == searchValue ||
                    x.MemberID.ToString().Substring(0, searchValueLength) == searchValue||
                    x.Email.Substring(0, searchValueLength) == searchValue
                    select new { x.MemberID, x.FirstName, x.LastName, x.Gender, x.Mobile, x.Email, x.EmergencyContact, Active = x.Active == 1 ? "Active" : "Discontinued" };
            MemberInfoTable.DataSource = q.ToList();
            SetColumnHeader();
        }

        private void SearchActiveMembers()
        {
            string searchValue = SearchTextBox.Text.ToString();
            int searchValueLength = searchValue.Length;
            var q = from x in ctx.Members
                    where x.Active == 1 && 
                    (x.FirstName.Substring(0, searchValueLength) == searchValue || 
                     x.LastName.Substring(0, searchValueLength) == searchValue || 
                     x.Mobile.Substring(4, searchValueLength) == searchValue ||
                     x.Email.Substring(0, searchValueLength) == searchValue ||
                     x.MemberID.ToString().Substring(0, searchValueLength) == searchValue)
                    select new { x.MemberID, x.FirstName, x.LastName, x.Gender, x.Mobile, x.Email, x.EmergencyContact, Active = x.Active == 1 ? "Active" : "Discontinued" };
            MemberInfoTable.DataSource = q.ToList();
            SetColumnHeader();

        }
     

        private void InactiveCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            if (InactiveCheckbox.Checked == true)
            {
                if (SearchTextBox.Text.ToString() == "")
                {
                    ViewAllMembers();
                }
                else
                {
                    SearchAllMembers();
                }
            }

            else
            {
                if (SearchTextBox.Text.ToString() == "")
                {
                    ViewActiveMembers();
                }
                else
                {
                    SearchActiveMembers();
                }
            }
        }



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InactiveCheckbox.Checked == true)
            {
                SearchAllMembers();
            }
            else
            {
                SearchActiveMembers();
            }
                
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int memberIdToDelete = (int)MemberInfoTable.SelectedRows[0].Cells[0].Value;
            Member memberToDelete = (from x in ctx.Members where x.MemberID == memberIdToDelete select x).First();

            if(memberToDelete.Active == 0)
            {
                MessageBox.Show("Already discontinued member!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to discontinue member?", "Confirm Member Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    memberToDelete.Active = 0;
                    ctx.SaveChanges();
    
                    MessageBox.Show(String.Format("Member ID: {0}\n Member Name: {1} {2} is discontinued!", memberToDelete.MemberID, memberToDelete.FirstName, memberToDelete.LastName));
                }
                else
                {
                    // user clicked no
                }
                
            }

            if (InactiveCheckbox.Checked == true)
            {
                SearchAllMembers();
            }
            else
                SearchActiveMembers();
        }

        private void BookHstryBttn_Click(object sender, EventArgs e)
        {
            //int memberID = (int)MemberInfoTable.SelectedRows[0].Cells[0].Value;
            //Member member = (from x in ctx.Members where x.MemberID == memberID select x).First();
            
        }

        private void ActivateMemberButton_Click(object sender, EventArgs e)
        {
            int memberIdToActivate = (int)MemberInfoTable.SelectedRows[0].Cells[0].Value;
            Member memberToActivate = (from x in ctx.Members where x.MemberID == memberIdToActivate select x).First();

            if (memberToActivate.Active == 1)
            {
                MessageBox.Show("Already activated member!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to activate member?", "Confirm Member Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    memberToActivate.Active = 1;
                    ctx.SaveChanges();

                    MessageBox.Show(String.Format("Member ID: {0}\nMember Name: {1} {2} is activated!", memberToActivate.MemberID, memberToActivate.FirstName, memberToActivate.LastName));
                }
               
            }

            if (InactiveCheckbox.Checked == true)
            {
                SearchAllMembers();
            }
            else
                SearchActiveMembers();
       
        }
    }
}
