using System;
using System.Windows.Forms;

namespace Ex10_04_MousePositionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            string msg = "Mouse Position : " + mousePoint.X + ", "+ mousePoint.Y;
            MessageBox.Show(msg);
        }
    }

}