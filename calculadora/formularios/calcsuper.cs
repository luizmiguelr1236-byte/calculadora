using System;
using System.CodeDom.Compiler;
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
            this.AcceptButton = btnig;
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


        private void operacoes(object sender, EventArgs e)
        {
            prinumero = decimal.Parse(labelvisor.Text);
            operacao = ((Button)sender).Text;
            limpar = true;
            lblhist.Text = " ";
            lblhist.Text = prinumero + operacao;
        }
        private void digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            if (labelvisor.Text == "0" || limpar)
            {
                labelvisor.Text = "";
                limpar = false;
            }

            labelvisor.Text += digito;


        }


        private void btnmaismenos_Click(object sender, EventArgs e)
        {
            decimal a = decimal.Parse(labelvisor.Text);
            decimal b = a * -1;
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
                        labelvisor.Text = Convert.ToString(prinumero + secnumero);
                        break;
                    case "-":
                        labelvisor.Text = (prinumero - secnumero).ToString();
                        break;
                    case "X":
                        labelvisor.Text = (prinumero * secnumero).ToString();
                        break;
                    case ":":
                        labelvisor.Text = (prinumero / secnumero).ToString();
                        break;
                    case "^":
                        labelvisor.Text = (Math.Pow(decimal.ToDouble(prinumero), decimal.ToDouble(secnumero))).ToString();
                        break;

                }
                lblhist.Text = prinumero + operacao + secnumero + "";
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
            this.AcceptButton = null;
        }

        private void lblhist_Click(object sender, EventArgs e)
        {

        }

        private void calcsuper_KeyDown(object sender, KeyEventArgs e)
        {
            Button botao = new Button();
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                digitos(botao, e);
            }
            switch (e.KeyCode)
            {
                case Keys.Add:
                    botao.Text = "+";
                    labelvisor.Text = " ";
                    operacoes(botao, e);
                    break;
                case Keys.Subtract:
                    botao.Text = "-";
                    operacoes(botao, e);
                    break;
                case Keys.Multiply:
                    botao.Text = "X";
                    operacoes(botao, e);
                    break;
                case Keys.Divide:
                    botao.Text = ":";
                    operacoes(botao, e);
                    break;
                

            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                button1_Click(botao, e);
            }
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                botao.Text = e.KeyCode.ToString().Substring(1);
                digitos(botao, e);
            }
            
        }
        private void calcsuper_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void calcsuper_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void calcsuper_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void btnvirgula_KeyDown(object sender, KeyEventArgs e)
        {
            Button botao = new Button();
            if (e.KeyCode == Keys.Oemcomma)
            {

            }
            else
            {
                botao.Text = e.KeyCode.ToString();
                digitos(botao, e);
            }
        }
    }
}
