using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsExercises
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Set up tooltip for the form
            toolTip1.SetToolTip(txtName, "Enter your name here");
            toolTip1.SetToolTip(btnLight, "Click me to: Turn OFF the Light, please!");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Update the button text with the name
            btnLight.Text = txtName.Text + " - Turn OFF the Light, please!";
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            // Toggle the button text between Turn OFF and Turn ON
            if (btnLight.Text.Contains("Turn OFF"))
            {
                btnLight.Text = txtName.Text + " - Turn ON the Light, please!";
            }
            else
            {
                btnLight.Text = txtName.Text + " - Turn OFF the Light, please!";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

