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
    
    public partial class radiobuttoncalc : Form
    {
        double a, b;
        public radiobuttoncalc()
        {
            InitializeComponent();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            oper.Text = " + ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            oper.Text = " - ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            oper.Text = " * ";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            oper.Text = " / ";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            oper.Text = " xˣ";
        }

        private void radiobuttoncalc_Load(object sender, EventArgs e)
        {
            
        }

        private void limpbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            result.Text = "";
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                result.Text = Convert.ToString(a + b);
            }
            else if (radioButton2.Checked)
            {
                result.Text = Convert.ToString(a - b);
            }
            else if (radioButton3.Checked)
            {
                result.Text = Convert.ToString(a * b);
            }
            else if (radioButton4.Checked)
            {
                result.Text = Convert.ToString(a / b);
            }
            if (radioButton5.Checked)
            {
                result.Text = Convert.ToString(Math.Pow(a,b));
            }
        }
    }
}
