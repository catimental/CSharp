﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ex09_04_MessageBoxButtonsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBoxButtons", "Title Bar", MessageBoxButtons.OKCancel);
        }

    }

}