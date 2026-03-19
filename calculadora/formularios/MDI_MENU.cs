using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
            novoForm.MdiParent = this;
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

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //datehour.Text =DateTime.Now.ToString();
        }

        private void comRadiobuttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radiobuttoncalc radiocalc = new radiobuttoncalc();
            radiocalc.MdiParent = this;
            radiocalc.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalmenrteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }

        private void visorUnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calcsuper radiocalc = new calcsuper();
            radiocalc.MdiParent = this;
            radiocalc.Show();
        }
    }
}
