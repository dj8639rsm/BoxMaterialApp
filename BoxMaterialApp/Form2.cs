﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxMaterialApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frmForm4 = new Form4();
            frmForm4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frmForm3 = new Form3();
            frmForm3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frmForm3 = new Form3();
            frmForm3.ShowDialog();
        }
    }
}
