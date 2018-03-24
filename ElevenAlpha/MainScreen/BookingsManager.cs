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
    public partial class BookingsManager : Form
    {
        ElevenAlphaEntities context;

        public BookingsManager(string facilityName, DateTime bookingDate)
        {
            InitializeComponent();

            // Initialize DB context
            context = new ElevenAlphaEntities();

            // Initialize values based on slot selected
            FacilityTypeComboBox.Text = facilityName;
            BookingDateTimePicker.Value = bookingDate;

            // Initialize watermark
            FirstNameTextBox_TextChanged(FirstNameTextBox, new EventArgs());
            LastNameTextBox_TextChanged(LastNameTextBox, new EventArgs());

            // Initialize comboBox Collection
            InitializeFacilityTypeComboBox();

            // Initialize dataGrid
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            throw new NotImplementedException();
        }

        private void InitializeFacilityTypeComboBox()
        {
            var list = context.FacilityTypes
                .Where(x => x.Active == 1)
                .ToList();

            foreach (var item in list)
            {
                FacilityTypeComboBox.Items.Add(item.Name);
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length == 0)
            {
                FirstNameTextBox.BackColor = SystemColors.Control;
                FirstNameTextBox.ForeColor = SystemColors.GrayText;
                //FirstNameTextBox.Font = new Font(FirstNameTextBox.Font, FontStyle.Italic);
                FirstNameTextBox.Text = "First Name";
            }
            else if (FirstNameTextBox.Text != "First Name")
            {
                FirstNameTextBox.BackColor = SystemColors.Control;
                FirstNameTextBox.ForeColor = SystemColors.ControlText;
                //FirstNameTextBox.Font = new Font(FirstNameTextBox.Font, FirstNameTextBox.Font.Style & ~FontStyle.Italic);
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length == 0)
            {
                LastNameTextBox.BackColor = SystemColors.Control;
                LastNameTextBox.ForeColor = SystemColors.GrayText;
                //LastNameTextBox.Font = new Font(LastNameTextBox.Font, FontStyle.Italic);
                LastNameTextBox.Text = "Last Name";
            }
            else if (LastNameTextBox.Text != "Last Name")
            {
                LastNameTextBox.BackColor = SystemColors.Control;
                LastNameTextBox.ForeColor = SystemColors.ControlText;
                //LastNameTextBox.Font = new Font(LastNameTextBox.Font, FirstNameTextBox.Font.Style & ~FontStyle.Italic);
            }
        }

        private void MemberIdTextBox_TextChanged(object sender, EventArgs e)
        {
            int memberId;

            if (MemberIdTextBox.Text == "") { }
            else if (Int32.TryParse(MemberIdTextBox.Text, out memberId))
            {
                if (context.Members.Where(x => x.MemberID == memberId).FirstOrDefault() is null)
                {
                    FirstNameTextBox.Text = "";
                    LastNameTextBox.Text = "";
                }
                else
                {
                    FirstNameTextBox.Text = context.Members.Where(x => x.MemberID == memberId).First().FirstName;
                    LastNameTextBox.Text = context.Members.Where(x => x.MemberID == memberId).First().LastName;
                }

            }
            else
            {
                MessageBox.Show("You have entered an invalid Member ID.");
            }
        }

        private void ShowMemberLookupButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
