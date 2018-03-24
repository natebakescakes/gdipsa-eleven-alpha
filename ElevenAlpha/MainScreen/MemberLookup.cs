using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevenAlpha
{
    public partial class MemberLookup : Form
    {
        ElevenAlphaEntities context;

        public MemberLookup()
        {
            InitializeComponent();
            context = new ElevenAlphaEntities();

            LoadMemberLookupDataGrid();
        }

        private void LoadMemberLookupDataGrid()
        {
            // Reload if searchbox is empty
            if (SearchTextBox.Text == "")
            {
                context.Members
                    .Where(x => x.Active == 1)
                    .Select(x => new
                    {
                        x.MemberID,
                        x.FirstName,
                        x.LastName,
                        x.Gender,
                        x.Mobile,
                        x.Email,
                        x.DateOfBirth
                    })
                    .ToList();
            }

            MemberLookupDataGrid.DataSource = context.Members
                .Where(x => (x.MemberID.ToString().Contains(SearchTextBox.Text) ||
                    x.FirstName.ToString().Contains(SearchTextBox.Text) ||
                    x.LastName.ToString().Contains(SearchTextBox.Text) ||
                    x.Mobile.ToString().Contains(SearchTextBox.Text) ||
                    x.Email.ToString().Contains(SearchTextBox.Text)) &&
                    x.Active == 1)
                .Select(x => new
                {
                    x.MemberID,
                    x.FirstName,
                    x.LastName,
                    x.Gender,
                    x.Mobile,
                    x.Email,
                    x.DateOfBirth
                })
                .ToList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadMemberLookupDataGrid();
        }
    }
}
