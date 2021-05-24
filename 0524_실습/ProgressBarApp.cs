using System;
using System.Windows.Forms;
namespace Ex11_07_ProgressBarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = progressBar1.Minimum; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
            }
        }
    }
}