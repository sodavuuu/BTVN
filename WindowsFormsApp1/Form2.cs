using System;
using System.Windows.Forms;

namespace WinFormsExercises
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;

            if (string.IsNullOrEmpty(txtYourName.Text))
            {
                errorProvider1.SetError(txtYourName, "You must enter Your Name");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (!int.TryParse(txtYear.Text, out age))
            {
                errorProvider1.SetError(txtYear, "This is an invalid number");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            // Calculate age
            int currentYear = DateTime.Now.Year;
            age = currentYear - age;

            MessageBox.Show($"My Name is: {txtYourName.Text}\nAge: {age}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text
            txtYourName.Clear();
            txtYear.Clear();

            // Set focus to Your Name textbox
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctrl, "You must enter Your Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && !int.TryParse(ctrl.Text, out _))
            {
                errorProvider1.SetError(ctrl, "This is an invalid number");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}

