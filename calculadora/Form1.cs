using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
        }

        private void btnsub_Click(object sender, EventArgs e)
        {

        }

        private void btnmult_Click(object sender, EventArgs e)
        {

        }

        private void btndiv_Click(object sender, EventArgs e)
        {

        }

        private void btncomp_Click(object sender, EventArgs e)
        {

        }

        private void btnparimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
