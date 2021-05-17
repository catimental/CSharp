﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ex09_10_ColorDialogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
            button2.BackColor = colorDialog1.Color;
        }
    }

}