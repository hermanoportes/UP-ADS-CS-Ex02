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
    public partial class FrmCadastrarAluno : Form
    {
        public FrmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                Aluno novoAluno = new Aluno();

                novoAluno.Matricula = int.Parse(txtMatricula.Text);
                novoAluno.Nome = txtNome.Text;
                novoAluno.DataNasc = maskTxtDataNasc.Text;
                if (rdBtnFem.Checked)
                {
                    novoAluno.Sexo = "Feminino";
                }
                else if (rdBtnMasc.Checked)
                {
                    novoAluno.Sexo = "Masculino";
                }

                AlunosController alunoController = new AlunosController();
                alunoController.Inserir(novoAluno);

                MessageBox.Show("Aluno cadastrado com sucesso!");
                txtMatricula.Text = null;
                txtNome.Text = null;
                maskTxtDataNasc.Text = null;
                rdBtnFem.Checked = false;
                rdBtnMasc.Checked = false;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar (" + ex.Message + ")");
            } 
        }
    }
}
