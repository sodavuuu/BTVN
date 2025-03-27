using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsExercises
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Hide the small CD
            picSmall.Visible = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Display the message with the selected color
            lblMessage.Visible = chkVisible.Checked;

            // Set the text color based on selected radio button
            if (radRed.Checked)
                lblMessage.ForeColor = Color.Red;
            else if (radGreen.Checked)
                lblMessage.ForeColor = Color.Green;
            else if (radBlue.Checked)
                lblMessage.ForeColor = Color.Blue;
            else if (radBlack.Checked)
                lblMessage.ForeColor = Color.Black;

            // Set the message text
            lblMessage.Text = txtName.Text + ": " + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text
            txtMessage.Clear();
            txtName.Clear();

            // Set focus to Name textbox
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            // Hide big CD, show small CD
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            // Hide small CD, show big CD
            picSmall.Visible = false;
            picBig.Visible = true;
        }
    }
}

