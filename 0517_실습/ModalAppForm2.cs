using System;
using System.Windows.Forms;
namespace Ex09_01_ModalApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}