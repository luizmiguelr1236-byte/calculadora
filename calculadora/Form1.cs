using calculadora.formularios;
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
        double a, b;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            try {a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            label1.Text = "+";
            result.Text = Convert.ToString(a+b); } catch (Exception ex) { MessageBox.Show("apenas números!","erro", MessageBoxButtons.OK); }
            
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                label1.Text = "-";
                result.Text = Convert.ToString(a - b);
            }
            catch (Exception ex) { MessageBox.Show("apenas números!", "erro", MessageBoxButtons.OK); }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                label1.Text = "*";
                result.Text = Convert.ToString(a * b);
            }
            catch (Exception ex) { MessageBox.Show("apenas números!", "erro", MessageBoxButtons.OK); }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                label1.Text = "/";
                result.Text = Convert.ToString(a / b);
            }
            catch (Exception ex) { MessageBox.Show("apenas números!", "erro", MessageBoxButtons.OK); }
        }

        private void btncomp_Click(object sender, EventArgs e)
        {
            try {a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            if (a > b) { 
                result.Text = $"o número {a} é maior";
            }
            else { 
                result.Text = $"o número {b} é maior"; 
            } }
            catch (Exception ex) { MessageBox.Show("apenas números!", "erro", MessageBoxButtons.OK); }

        }

        private void btnparimpar_Click(object sender, EventArgs e)
        {
            try {a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            if (a % 2 == 0 && b % 2 == 0) { result.Text = "os dois são pares"; }
            else if (a % 2 == 0 && b % 2 != 0) { result.Text = $" {a} é par e {b} é impar"; }
            else if (a % 2 != 0 && b % 2 == 0) { result.Text = $" {a} é impar e {b} é par"; }
            else { result.Text = "os dois são impares"; } }
            catch (Exception ex) { MessageBox.Show("apenas números!", "erro", MessageBoxButtons.OK); }


        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnsomar, "use virgula para numeros decimais");
            toolTip2.SetToolTip(btnsub, "use virgula para numeros decimais");
            toolTip3.SetToolTip(btndiv, "use virgula para numeros decimais");
            toolTip4.SetToolTip(btnmult, "use virgula para numeros decimais");
            toolTip5.SetToolTip(btncomp, "use virgula para numeros decimais");
            toolTip6.SetToolTip(btnparimpar, "não use numeros decimais ou todos serão impares");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            label1.Text = "  ";
            textBox1.Text = "";
            result.Text = "";
            textBox2.Text = "";

        }
    }
}
