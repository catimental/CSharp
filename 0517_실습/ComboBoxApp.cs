using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ex08_08_ComboBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }
    }
}