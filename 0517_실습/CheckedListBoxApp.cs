using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ex08_09_CheckedListBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strTemp = "";
            foreach (object obj in checkedListBox1.CheckedItems)
            {
                strTemp += obj.ToString();
                strTemp += " ";
            }
            MessageBox.Show("당신의 취미는 " + strTemp + "입니다. ");
        }
    }
}