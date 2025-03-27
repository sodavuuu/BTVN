using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsExercises
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // Initialize the form
        }

        private void lnkWindowsForms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkWindowsForms.LinkVisited = true;
            System.Diagnostics.Process.Start("Firefox", "http://www.windowsforms.net");
        }

        private void lnkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkCalculator.LinkVisited = true;
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void lnkCDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkCDrive.LinkVisited = true;
            System.Diagnostics.Process.Start("explorer.exe", "C:\\");
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            // Hide picTurnOn, show picTurnOff
            picTurnOn.Visible = false;
            picTurnOff.Visible = true;

            // Update label text
            lblLight.Text = txtName.Text + " - Turn OFF the Light, please!";
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            // Hide picTurnOff, show picTurnOn
            picTurnOff.Visible = false;
            picTurnOn.Visible = true;

            // Update label text
            lblLight.Text = txtName.Text + " - Turn ON the Light, please!";
        }
    }
}

