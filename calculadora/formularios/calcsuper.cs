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
        decimal prinumero;
        string operacao;
        bool limpar;
        public calcsuper()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if (labelvisor.Text.Contains(btnvirgula.Text))
            {

            }
            else
            {
                labelvisor.Text += ((Button)sender).Text;
            }
        }

        private void btnsom_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }
        private void operacoes(object sender, EventArgs e)
        {
            prinumero = decimal.Parse(labelvisor.Text);
            operacao = ((Button)sender).Text;
            limpar = true;
            lblhist.Text = prinumero + "" + operacao + "";
        }
        private void digitos(object sender, EventArgs e)
        {
            string dogito = ((Button)sender).Text;
            if (labelvisor.Text == "0" || limpar)
            {
                labelvisor.Text = "";
                limpar = false;
            }

            labelvisor.Text += dogito;


        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            labelvisor.Text += ((Button)sender).Text;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            
        }

        private void btnpot_Click(object sender, EventArgs e)
        {
            labelvisor.Text += "^";
        }

        private void btnmaismenos_Click(object sender, EventArgs e)
        {
            double a = double.Parse(labelvisor.Text);
            double b = a * -1;
            labelvisor.Text = Convert.ToString(b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal secnumero = decimal.Parse(labelvisor.Text);
                switch (operacao)
                {
                    case "+":
                        labelvisor.Text = (prinumero + secnumero).ToString();
                        break;
                    case "-":
                        labelvisor.Text = (prinumero - secnumero).ToString();
                        break;
                    case "X":
                        labelvisor.Text = (prinumero * secnumero).ToString();
                        break;
                    case "/":
                        labelvisor.Text = (prinumero / secnumero).ToString();
                        break;
                        //case "^":
                        //    labelvisor.Text = (Math.Pow(prinumero, secnumero)).ToString();
                        //    break;
                        lblhist.Text = prinumero + "" + operacao + "";
                }
            }
            
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            labelvisor.Text = "";
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(labelvisor.Text))
            {
                labelvisor.Text = labelvisor.Text.Substring(0, labelvisor.Text.Length - 1);
            }
        }

        private void calcsuper_Load(object sender, EventArgs e)
        {
            lblhist.Text = "";
        }
    }
}
