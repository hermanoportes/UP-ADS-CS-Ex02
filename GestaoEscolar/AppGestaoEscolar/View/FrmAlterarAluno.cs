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
    public partial class FrmAlterarAluno : Form
    {
        public FrmAlterarAluno()
        {
            InitializeComponent();
        }

        private void FrmAlterarAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoEscolarDBDataSet1.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter1.Fill(this.gestaoEscolarDBDataSet1.Alunos);
            // TODO: esta linha de código carrega dados na tabela 'gestaoEscolarDBDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.gestaoEscolarDBDataSet.Alunos);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatricula.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            maskTxtDataNasc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            if (Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value) == "Feminino")
            {
                rdBtnFem.Checked = true;
            }
            else if (Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value) == "Masculino")
            {
                rdBtnMasc.Checked = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();

                aluno.Id = int.Parse(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                aluno.Matricula = int.Parse(txtMatricula.Text);
                aluno.Nome = txtNome.Text;
                aluno.DataNasc = maskTxtDataNasc.Text;
                if (rdBtnFem.Checked)
                {
                    aluno.Sexo = "Feminino";
                }
                else if (rdBtnMasc.Checked)
                {
                    aluno.Sexo = "Masculino";
                }

                AlunosController alunoController = new AlunosController();
                alunoController.Alterar(aluno);

                MessageBox.Show("Dados alterados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar dados do Aluno (" + ex.Message + ")");
            }
        }
    }
}
