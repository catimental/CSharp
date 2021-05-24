using System;
using System.Windows.Forms;
namespace Ex11_08_TimerApp
{
    public partial class Form1 : Form
    {
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            index %= imageList1.Images.Count;
            label1.Image = imageList1.Images[index++];
        }
    }
}