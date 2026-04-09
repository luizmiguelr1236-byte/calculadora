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
        private Dictionary<Button, Color> originalColors = new Dictionary<Button, Color>();
        private readonly Color pressedColor = Color.FromArgb(190, 190, 190);
        private Button selectedButton = null;

        public calcsuper()
        {
            InitializeComponent();
            this.AcceptButton = btnig;
            
            this.KeyPreview = true;
            RegisterButtonEvents(this);
            
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
            this.ActiveControl = null;
            this.Focus();

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
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                btndel_Click(botao, e);
            }
            if (e.KeyCode == Keys.Back)
            {
                btndel_Click(botao, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                digitos(botao, e);
                Button realBtn = FindButtonByName("btn" + e.KeyCode.ToString().Substring(6));
                if (realBtn != null)
                    SelectButton(realBtn);
            }
            switch (e.KeyCode)
            {
                case Keys.Add:
                    botao.Text = "+";
                    operacoes(botao, e);
                    labelvisor.Text = "0";
                    {
                        Button realBtn = FindButtonByName("btnmais");
                        if (realBtn != null) SelectButton(realBtn);
                    }
                    break;
                case Keys.Subtract:
                    botao.Text = "-";
                    operacoes(botao, e);
                    labelvisor.Text = "0";
                    {
                        Button realBtn = FindButtonByName("btnmenos");
                        if (realBtn != null) SelectButton(realBtn);
                    }
                    break;
                case Keys.Multiply:
                    botao.Text = "X";
                    operacoes(botao, e);
                    labelvisor.Text = "0";
                    {
                        Button realBtn = FindButtonByName("btnvezes");
                        if (realBtn != null) SelectButton(realBtn);
                    }
                    break;
                case Keys.Divide:
                    botao.Text = ":";
                    operacoes(botao, e);
                    labelvisor.Text = "0";
                    {
                        Button realBtn = FindButtonByName("btndividir");
                        if (realBtn != null) SelectButton(realBtn);
                    }
                    break;
                case Keys.Enter:
                    button1_Click(botao, e);
                    {
                        Button realBtn = FindButtonByName("btnig");
                        if (realBtn != null) SelectButton(realBtn);
                    }
                    break;
                   
            }
            
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                botao.Text = e.KeyCode.ToString().Substring(1);
                digitos(botao, e);
                Button realBtn = FindButtonByName("btn" + e.KeyCode.ToString().Substring(1));
                if (realBtn != null) SelectButton(realBtn);
            }

        }
        private void calcsuper_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (KeyPreview)
            {
               
                string name = null;
                if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                    name = "btn" + e.KeyCode.ToString().Substring(6);
                else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                    name = "btn" + e.KeyCode.ToString().Substring(1);
                else
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Add: name = "btnmais"; break;
                        case Keys.Subtract: name = "btnmenos"; break;
                        case Keys.Multiply: name = "btnvezes"; break;
                        case Keys.Divide: name = "btndividir"; break;
                        case Keys.Enter: name = "btnig"; break;
                    }
                }

                if (!string.IsNullOrEmpty(name))
                {
                    Button btn = FindButtonByName(name);
                    if (btn != null && originalColors.ContainsKey(btn) && btn != selectedButton)
                        btn.BackColor = originalColors[btn];
                }
            }
        }

        private void RegisterButtonEvents(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                  
                    btn.UseVisualStyleBackColor = false;
                    if (!originalColors.ContainsKey(btn))
                        originalColors[btn] = Color.White;
                    btn.BackColor = Color.White;

                    btn.MouseDown += Button_MouseDown;
                    btn.MouseUp += Button_MouseUp;
                }

                if (c.HasChildren)
                    RegisterButtonEvents(c);
            }
        }

      
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                SelectButton(btn);
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button btn && selectedButton != btn && originalColors.ContainsKey(btn))
            {
                btn.BackColor = originalColors[btn];
            }
        }

        private void SelectButton(Button btn)
        {
            if (btn == null) return;

           
            if (selectedButton != null && selectedButton != btn && originalColors.ContainsKey(selectedButton))
                selectedButton.BackColor = originalColors[selectedButton];

            selectedButton = btn;
            if (!originalColors.ContainsKey(btn))
                originalColors[btn] = Color.White;
            btn.BackColor = pressedColor;
        }

        private Button FindButtonByName(string name)
        {
            return this.Controls.Find(name, true).FirstOrDefault() as Button;
        }

        private void calcsuper_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void calcsuper_KeyUp_1(object sender, KeyEventArgs e)
        {
   
        }

        private void btnvirgula_KeyDown(object sender, KeyEventArgs e)
        {
        }

    }
}