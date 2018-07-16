using AppGestaoEscolar.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestaoEscolar
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCadastrarAluno_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmCadastrarAluno());
        }

        private void menuAlterarAluno_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmAlterarAluno());
        }

        private void menuExcluirAluno_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmExcluirAluno());
        }

        private void menuListarAlunos_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmListarAlunos());
        }

        private void menuBuscarAluno_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmBuscarAluno());
        }

        private void MenuCadastrarProfessor_Click(object sender, EventArgs e)
        {
            this.MostraForm(new FrmCadastrarProfessor());
        }

        private void MenuAlterarProfessor_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmAlterarProfessor());
        }

        private void MenuExcluirProfessor_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmExcluirProfessor());
        }

        private void MenuListarProfessores_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmListarProfessores());
        }

        private void MenuBuscarProfessor_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmCadastrarAlunBuscarProfessor());
        }

        private void MenuCadastrarDisciplina_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmCadastrarDisciplina());
        }

        private void MenuConsultarDisciplinas_Click(object sender, EventArgs e)
        {
            //this.MostraForm(new FrmConsultar Disciplinas());
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
