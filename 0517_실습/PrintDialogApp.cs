using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ex09_11_PrintDialogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PrinterSettings printer = new PrinterSettings();
            PrintDocument printDocument = new PrintDocument();
            printDialog1.PrinterSettings = printer;
            printDialog1.Document = printDocument;
            printDialog1.ShowDialog();
        }
    }

}