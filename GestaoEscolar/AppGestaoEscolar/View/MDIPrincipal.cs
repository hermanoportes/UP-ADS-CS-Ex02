using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestaoEscolar.View
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmAlunos());
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmProfessores());
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmDisciplinas());
        }

        private void MostraForm(Form form)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.GetType() == form.GetType())
                {
                    frmChild.Focus();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        
    }
}
