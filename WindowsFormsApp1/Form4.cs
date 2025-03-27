using System;
using System.Windows.Forms;

namespace WinFormsExercises
{
    public partial class Form4 : Form
    {
        // Exchange rates
        private const decimal USD_TO_VND = 17861;
        private const decimal EUR_TO_VND = 27043;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Set default radio button
            radVNDtoUSD.Checked = true;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal amount;
            decimal result = 0;

            // Validate input
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                errorProvider1.SetError(txtAmount, "Vui lòng nhập số hợp lệ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            // Perform conversion based on selected radio button
            if (radVNDtoUSD.Checked)
            {
                result = Math.Round(amount / USD_TO_VND, 2);
                txtResult.Text = result.ToString();
            }
            else if (radUSDtoVND.Checked)
            {
                result = Math.Round(amount * USD_TO_VND, 0);
                txtResult.Text = result.ToString();
            }
            else if (radVNDtoEUR.Checked)
            {
                result = Math.Round(amount / EUR_TO_VND, 2);
                txtResult.Text = result.ToString();
            }
            else if (radEURtoVND.Checked)
            {
                result = Math.Round(amount * EUR_TO_VND, 0);
                txtResult.Text = result.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtResult.Clear();
            txtAmount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn thoát khỏi chương trình không?",
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

