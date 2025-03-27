using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsExercises
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Set default radio button
            radRed.Checked = true;

            // Set default date
            txtNhapTen.Text = "Tên 2011";
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            // Update lblLapTrinh text with the content from txtNhapTen
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            // Change text color to red when Red radio button is checked
            if (radRed.Checked)
            {
                lblLapTrinh.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            // Change text color to green when Green radio button is checked
            if (radGreen.Checked)
            {
                lblLapTrinh.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            // Change text color to blue when Blue radio button is checked
            if (radBlue.Checked)
            {
                lblLapTrinh.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            // Change text color to black when Black radio button is checked
            if (radBlack.Checked)
            {
                lblLapTrinh.ForeColor = Color.Black;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            // Update font style based on checkbox states
            UpdateFontStyle();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            // Update font style based on checkbox states
            UpdateFontStyle();
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            // Update font style based on checkbox states
            UpdateFontStyle();
        }

        private void UpdateFontStyle()
        {
            // Create a new font style based on checkbox states
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;

            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            // Apply the new font style
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.FontFamily, lblLapTrinh.Font.Size, style);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

