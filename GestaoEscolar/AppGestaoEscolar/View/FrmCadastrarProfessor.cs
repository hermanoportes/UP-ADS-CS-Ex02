using AppGestaoEscolar.Controller;
using AppGestaoEscolar.Model.DAL;
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
    public partial class FrmCadastrarProfessor : Form
    {
        public FrmCadastrarProfessor()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor novoProfessor = new Professor();

                novoProfessor.Nome = txtNome.Text;
                novoProfessor.Formacao = txtFormacao.Text;
                novoProfessor.Salario = txtSalario.Text;
                novoProfessor.DataInicial = maskDataInic.Text;
               
                ProfessoresController professorController = new ProfessoresController();
                professorController.Inserir(novoProfessor);

                MessageBox.Show("Professor cadastrado com sucesso!");
                txtNome.Text = null;
                txtFormacao.Text = null;
                txtSalario.Text = null;
                maskDataInic.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar (" + ex.Message + ")");
            }
        }
    }
}
