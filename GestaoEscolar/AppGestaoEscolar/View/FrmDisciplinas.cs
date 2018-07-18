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
    public partial class FrmDisciplinas : Form
    {
        public string professorId;

        public FrmDisciplinas()
        {
            InitializeComponent();
        }

        private void FrmDisciplinas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'disciplinasDataSet.Disciplinas'. Você pode movê-la ou removê-la conforme necessário.
            this.disciplinasTableAdapter.Fill(this.disciplinasDataSet.Disciplinas);            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscaProfessor frmBuscaProfessor = new FrmBuscaProfessor();
            frmBuscaProfessor.ShowDialog();
            txtProfessorId.Text = frmBuscaProfessor.professorId;
        }
         
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Disciplina disciplina = new Disciplina();

                if (txtId.Text != "")
                    disciplina.Id = int.Parse(txtId.Text);
                disciplina.Nome = txtNome.Text;
                disciplina.CargaHoraria = int.Parse(txtCH.Text);
                disciplina.ProfessorId = int.Parse(txtProfessorId.Text);

                DisciplinasController disciplinasController = new DisciplinasController();

                if (disciplina.Id == 0)
                {
                    disciplinasController.Inserir(disciplina);
                    MessageBox.Show("Disciplina cadastrada com sucesso!");
                }
                else
                {
                    disciplinasController.Alterar(disciplina);
                    MessageBox.Show("Disciplina alterada com sucesso!");
                }

                this.disciplinasTableAdapter.Fill(this.disciplinasDataSet.Disciplinas);

                txtId.Text = null;
                txtNome.Text = null;
                txtCH.Text = null;
                txtProfessorId.Text = null;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar (" + ex.Message + ")");
            } 
        }

        private void dGVDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDisciplinas.CurrentRow.Cells[5].Selected)
            {
                CarregarDados();

            }
            else if (dGVDisciplinas.CurrentRow.Cells[6].Selected)
            {
                try
                {
                    DisciplinasController disciplinasController = new DisciplinasController();
                    disciplinasController.Excluir(int.Parse(Convert.ToString(dGVDisciplinas.CurrentRow.Cells[0].Value)));

                    MessageBox.Show("Disciplina excluida com sucesso!");

                    disciplinasTableAdapter.Fill(this.disciplinasDataSet.Disciplinas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir (" + ex.Message + ")");
                }
            }
            else if (dGVDisciplinas.CurrentRow.Cells[4].Selected)
            {
                FrmAlunosDisciplina frmAlunosDisciplina = new FrmAlunosDisciplina();                              
                frmAlunosDisciplina.ShowDialog();                
            }
        }

        private void CarregarDados()
        {
            txtId.Text = Convert.ToString(dGVDisciplinas.CurrentRow.Cells[0].Value);            
            txtNome.Text = Convert.ToString(dGVDisciplinas.CurrentRow.Cells[1].Value);
            txtCH.Text = Convert.ToString(dGVDisciplinas.CurrentRow.Cells[2].Value);
            txtProfessorId.Text = Convert.ToString(dGVDisciplinas.CurrentRow.Cells[3].Value);            
        }
    }
}
