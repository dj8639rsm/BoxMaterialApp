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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Form2 frmForm2 = new Form2();
            frmForm2.ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
