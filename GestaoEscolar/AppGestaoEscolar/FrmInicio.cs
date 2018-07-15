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
            new FrmCadastrarAluno().Show();
        }

        private void menuAlterarAluno_Click(object sender, EventArgs e)
        {

        }

        private void menuExcluirAluno_Click(object sender, EventArgs e)
        {

        }

        private void menuListarAlunos_Click(object sender, EventArgs e)
        {

        }

        private void menuBuscarAluno_Click(object sender, EventArgs e)
        {

        }

        private void MenuCadastrarProfessor_Click(object sender, EventArgs e)
        {

        }

        private void MenuAlterarProfessor_Click(object sender, EventArgs e)
        {

        }

        private void MenuExcluirProfessor_Click(object sender, EventArgs e)
        {

        }

        private void MenuListarProfessores_Click(object sender, EventArgs e)
        {

        }

        private void MenuBuscarProfessor_Click(object sender, EventArgs e)
        {

        }

        private void MenuCadastrarDisciplina_Click(object sender, EventArgs e)
        {

        }

        private void MenuConsultarDisciplinas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }        
    }
}
