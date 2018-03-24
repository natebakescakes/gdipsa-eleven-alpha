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
        public BookingsManager()
        {
            InitializeComponent();
            FirstNameTextBox_TextChanged(FirstNameTextBox, new EventArgs());
            LastNameTextBox_TextChanged(LastNameTextBox, new EventArgs());
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length == 0)
            {
                FirstNameTextBox.BackColor = SystemColors.Control;
                FirstNameTextBox.ForeColor = SystemColors.GrayText;
                FirstNameTextBox.Font = new Font(FirstNameTextBox.Font, FontStyle.Italic);
                FirstNameTextBox.Text = "First Name";
            }
            else if (FirstNameTextBox.Text != "First Name")
            {
                FirstNameTextBox.BackColor = SystemColors.Control;
                FirstNameTextBox.ForeColor = SystemColors.ControlText;
                FirstNameTextBox.Font = new Font(FirstNameTextBox.Font, FirstNameTextBox.Font.Style & ~FontStyle.Italic);
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length == 0)
            {
                LastNameTextBox.BackColor = SystemColors.Control;
                LastNameTextBox.ForeColor = SystemColors.GrayText;
                LastNameTextBox.Font = new Font(LastNameTextBox.Font, FontStyle.Italic);
                LastNameTextBox.Text = "Last Name";
            }
            else if (LastNameTextBox.Text != "Last Name")
            {
                LastNameTextBox.BackColor = SystemColors.Control;
                LastNameTextBox.ForeColor = SystemColors.ControlText;
                LastNameTextBox.Font = new Font(LastNameTextBox.Font, FirstNameTextBox.Font.Style & ~FontStyle.Italic);
            }
        }
    }
}
