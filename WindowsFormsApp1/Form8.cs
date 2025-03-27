using System;
using System.Windows.Forms;

namespace WinFormsExercises
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, x;

            // Validate input for A
            if (!double.TryParse(txtA.Text, out a))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập số hợp lệ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            // Validate input for B
            if (!double.TryParse(txtB.Text, out b))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập số hợp lệ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            // Check if A is zero (not a valid linear equation)
            if (a == 0)
            {
                if (b == 0)
                {
                    txtNghiem.Text = "Phương trình vô số nghiệm";
                }
                else
                {
                    txtNghiem.Text = "Phương trình vô nghiệm";
                }
            }
            else
            {
                // Calculate the solution
                x = -b / a;
                txtNghiem.Text = x.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtA.Clear();
            txtB.Clear();
            txtNghiem.Clear();

            // Set focus to A
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn thoát khỏi ứng dụng hay không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

