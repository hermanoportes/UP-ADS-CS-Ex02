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

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();        
        }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmCadastrarAluno());
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmAlterarAluno());
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmExcluirAluno());
        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmListarAlunos());
        }

        private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmBuscarAluno());
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmCadastrarProfessor());
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmAlterarProfessor());
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmExcluirProfessor());
        }

        private void listarProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmListarProfessores());
        }

        private void buscarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmBuscarProfessor());
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmCadastrarDisciplina());
        }

        private void consultarDisciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmConsultarDisciplinas());
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
