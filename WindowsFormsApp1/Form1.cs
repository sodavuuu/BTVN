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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SimpleEvent
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "SimpleEvent";
            this.Load += new System.EventHandler(this.SimpleEvent_Load_1);
            this.ResumeLayout(false);

        }

        private void SimpleEvent_Load_1(object sender, EventArgs e)
        {

        }
    }
}
