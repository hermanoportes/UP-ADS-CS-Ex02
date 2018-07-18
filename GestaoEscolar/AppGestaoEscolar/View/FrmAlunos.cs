using AppGestaoEscolar.AlunosDataSetTableAdapters;
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
    public partial class FrmAlunos : Form
    {
        public FrmAlunos()
        {
            InitializeComponent();
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'alunosDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.alunosDataSet.Alunos);

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();

                if (txtId.Text != "")
                    aluno.Id = int.Parse(txtId.Text);
                aluno.Matricula = int.Parse(txtMatricula.Text);
                aluno.Nome = txtNome.Text;
                aluno.DataNasc = maskDataNasc.Text;
                if (rdBtnFem.Checked)
                {
                    aluno.Sexo = rdBtnFem.Text;
                }
                else if (rdBtnMasc.Checked)
                {
                    aluno.Sexo = rdBtnMasc.Text;
                }                

                AlunosController alunoController = new AlunosController();

                if (aluno.Id == 0)
                {                    
                    alunoController.Inserir(aluno);
                    MessageBox.Show("Aluno cadastrado com sucesso!");                    
                }
                else
                {
                    alunoController.Alterar(aluno);
                    MessageBox.Show("Aluno alterado com sucesso!");
                }

                this.alunosTableAdapter.Fill(this.alunosDataSet.Alunos);
                
                txtId.Text = null;
                txtMatricula.Text = null;
                txtNome.Text = null;
                maskDataNasc.Text = null;
                rdBtnFem.Checked = false;
                rdBtnMasc.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar (" + ex.Message + ")");
            }
        }

        private void dGVAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (dGVAlunos.CurrentRow.Cells[5].Selected)
            {
                CarregarDados();

            }
            else if (dGVAlunos.CurrentRow.Cells[6].Selected)
            {
                try
                {
                    AlunosController alunoController = new AlunosController();
                    alunoController.Excluir(int.Parse(Convert.ToString(dGVAlunos.CurrentRow.Cells[0].Value)));

                    MessageBox.Show("Aluno excluido com sucesso!");

                    alunosTableAdapter.Fill(this.alunosDataSet.Alunos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir (" + ex.Message + ")");
                }
            }
        }

        private void CarregarDados()
        {
            txtId.Text = Convert.ToString(dGVAlunos.CurrentRow.Cells[0].Value);
            txtMatricula.Text = Convert.ToString(dGVAlunos.CurrentRow.Cells[1].Value);
            txtNome.Text = Convert.ToString(dGVAlunos.CurrentRow.Cells[2].Value);
            maskDataNasc.Text = Convert.ToString(dGVAlunos.CurrentRow.Cells[3].Value);
            if (Convert.ToString(dGVAlunos.CurrentRow.Cells[4].Value) == "Feminino")
            {
                rdBtnFem.Checked = true;
            }
            else if (Convert.ToString(dGVAlunos.CurrentRow.Cells[4].Value) == "Masculino")
            {
                rdBtnMasc.Checked = true;
            }
        }
    }
}
