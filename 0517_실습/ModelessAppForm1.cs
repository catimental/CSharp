﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ex09_02_ModelessApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //modeless
        }
    }

}