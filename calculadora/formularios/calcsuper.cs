using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora.formularios
{
    public partial class calcsuper : Form
    {
        public calcsuper()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btn9.Text;
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            string a = btnvirgula.Text;
            if (labelvisor.Text.Contains(a)) { 
                
            }
            else
            {
                labelvisor.Text += btnvirgula.Text;
            }
        }

        private void btnsom_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btnsom.Text;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btnmin.Text;
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btnmult.Text;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            labelvisor.Text += btndiv.Text;
        }

        private void btnpot_Click(object sender, EventArgs e)
        {
            labelvisor.Text += "^";
        }

        private void btnmaismenos_Click(object sender, EventArgs e)
        {
            double a = double.Parse(labelvisor.Text);
            double b = a - 2 * a;
            labelvisor.Text = Convert.ToString(b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ska = {"+","-","X",":","^"};
            string sla = labelvisor.Text, b1, b2;
            if (sla.Contains(ska[1])) {
                b1 = sla.Split('+')[0];
                b2 = sla.Split('+')[1];
                int c1 = Convert.ToInt32 (b1);
                int c2 = Convert.ToInt32(b2);
                labelvisor.Text = (Convert.ToString(c1+c2));
            }
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            labelvisor.Text = "0";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
