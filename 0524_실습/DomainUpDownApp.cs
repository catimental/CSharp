using System;
using System.Windows.Forms;
namespace Ex11_04_DomainUpDownApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.SelectedItem.ToString());
        }
    }
}