using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsExercises
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void lnkPrograms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Launch the program stored in the hyperlink
            System.Diagnostics.Process.Start(
                ((LinkLabel)sender).Text);
        }

        private void btnExercise2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void btnExercise3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void btnExercise4_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void btnExercise5_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }

        private void btnExercise6_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void btnExercise7_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void btnExercise8_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.ShowDialog();
        }

        private void btnExercise9_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.ShowDialog();
        }

        private void btnWindowsForms_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Firefox", "http://www.windowsforms.net");
        }
    }
}

