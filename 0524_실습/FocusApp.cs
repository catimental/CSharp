using System;
using System.Windows.Forms;
namespace Ex10_07_FocusApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = SystemColors.Control;
            this.button2.Focus();
            if (this.button2.Focused)
            {
                this.button2.BackColor = SystemColors.ControlDark;   
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = SystemColors.Control;
            this.button1.Focus();
            if (this.button1.Focused)
            {
                this.button1.BackColor = SystemColors.ControlDark;
            }
        }
    }
}