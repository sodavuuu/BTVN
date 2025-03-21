using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SimpleEvent : Form
    {
        public SimpleEvent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked");
        }

        private void SimpleEvent_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Welcome to C# 2010 programming");
        }

        private void SimpleEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked");
        }
    }
}
