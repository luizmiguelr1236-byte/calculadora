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
    public partial class MDI_MENU : Form
    {
        public MDI_MENU()
        {
            InitializeComponent();
        }

        private void MDI_MENU_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void comBotoesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 novoForm = new Form1();
            novoForm.Show();
        }

        private void MDI_MENU_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?" , "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.Yes) { e.Cancel = false; }
            else if (resultado == DialogResult.No) { e.Cancel = true;  }

            /*
             ou if(MessageBox.Show("Deseja realmente sair?" , "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No){
                    e.Cancel = true;
                }
                else{
                    
                }
             */
        }
    }
}
