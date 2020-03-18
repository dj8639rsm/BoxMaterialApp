using System;
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
            Form6 frmForm6 = new Form6();
            frmForm6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frmForm5 = new Form5();
            frmForm5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frmForm3 = new Form3();
            frmForm3.ShowDialog();
        }
    }
}
