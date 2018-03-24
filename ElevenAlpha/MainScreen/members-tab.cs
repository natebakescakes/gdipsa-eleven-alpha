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
        }

        private void ViewActiveMembers()
        {
            MemberInfoTable.DataSource = ctx.Members.Where(x => x.Active == 1)
              .Select(x => new { x.MemberID, x.FirstName, x.LastName, x.Gender, x.Mobile, x.Email, x.EmergencyContact, Active = x.Active == 1 ? "Active" : "Discontinued" }).ToList();
        }


        private void SearchAllMembers()
        {
            string searchValue = SearchTextBox.Text.ToString();
            int searchValueLength = searchValue.Length;
            var q = from x in ctx.Members
                    where x.FirstName.Substring(0, searchValueLength) == searchValue || x.LastName.Substring(0, searchValueLength) == searchValue || x.Mobile.Substring(4, searchValueLength) == searchValue || x.MemberID.ToString().Substring(0, searchValueLength) == searchValue
                    select new { x.MemberID, x.FirstName, x.LastName, x.Gender, x.Mobile, x.Email, x.EmergencyContact, Active = x.Active == 1 ? "Active" : "Discontinued" };
            MemberInfoTable.DataSource = q.ToList();
        }

        private void SearchActiveMembers()
        {
            string searchValue = SearchTextBox.Text.ToString();
            int searchValueLength = searchValue.Length;
            var q = from x in ctx.Members
                    where x.Active == 1 && (x.FirstName.Substring(0, searchValueLength) == searchValue || x.LastName.Substring(0, searchValueLength) == searchValue || x.Mobile.Substring(4, searchValueLength) == searchValue || x.MemberID.ToString().Substring(0, searchValueLength) == searchValue)
                    select new { x.MemberID, x.FirstName, x.LastName, x.Gender, x.Mobile, x.Email, x.EmergencyContact, Active = x.Active == 1 ? "Active" : "Discontinued" };
            MemberInfoTable.DataSource = q.ToList();

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
                memberToDelete.Active = 0;
                ctx.SaveChanges();
                MessageBox.Show(String.Format("Member ID: {0}\n Member Name: {1} {2} is discontinued!",memberToDelete.MemberID,memberToDelete.FirstName,memberToDelete.LastName));
            }

            if (InactiveCheckbox.Checked == true)
            {
                ViewAllMembers();
            }
            else
                ViewActiveMembers();
        }

        private void BookHstryBttn_Click(object sender, EventArgs e)
        {
            //int memberID = (int)MemberInfoTable.SelectedRows[0].Cells[0].Value;
            //Member member = (from x in ctx.Members where x.MemberID == memberID select x).First();
            
        }
    }
}
