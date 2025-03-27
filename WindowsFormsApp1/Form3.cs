using System;
using System.Windows.Forms;

namespace WinFormsExercises
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTen.Focus();
            }
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnHoTen.PerformClick();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHo.Clear();
            txtTen.Clear();
            lblHoTen.Text = "";
            txtHo.Focus();
        }
    }
}

