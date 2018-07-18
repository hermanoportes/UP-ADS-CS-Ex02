using AppGestaoEscolar.AlunosDataSetTableAdapters;
using AppGestaoEscolar.Controller;
using AppGestaoEscolar.Model.DAL;
using AppGestaoEscolar.ProfessoresDataSetTableAdapters;
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
    public partial class FrmProfessores : Form
    {
        public FrmProfessores()
        {
            InitializeComponent();
        }

        private void FrmProfessores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'professoresDataSet.Professores'. Você pode movê-la ou removê-la conforme necessário.
            this.professoresTableAdapter.Fill(this.professoresDataSet.Professores);

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = new Professor();

                if (txtId.Text != "") 
                    professor.Id = int.Parse(txtId.Text);
                                              
                professor.Nome = txtNome.Text;
                professor.Formacao = txtFormacao.Text;
                professor.Salario = txtSalario.Text;
                professor.DataInicial = maskDataInic.Text;                
                

                ProfessoresController professorController = new ProfessoresController();

                if (professor.Id == 0)
                {
                    professorController.Inserir(professor);
                    MessageBox.Show("Professor cadastrado com sucesso!");
                }
                else
                {
                    professorController.Alterar(professor);
                    MessageBox.Show("Professor alterado com sucesso!");
                }
                               
                this.professoresTableAdapter.Fill(this.professoresDataSet.Professores);

                txtId.Text = null;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVProfessores.CurrentRow.Cells[5].Selected)
            {
                CarregarDados();

            }
            else if (dGVProfessores.CurrentRow.Cells[6].Selected)
            {
                try
                {
                    ProfessoresController professorController = new ProfessoresController();
                    professorController.Excluir(int.Parse(Convert.ToString(dGVProfessores.CurrentRow.Cells[0].Value)));

                    MessageBox.Show("Professor excluido com sucesso!");

                    professoresTableAdapter.Fill(this.professoresDataSet.Professores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir (" + ex.Message + ")");
                }
            }
        }

        private void CarregarDados()
        {
            txtId.Text = Convert.ToString(dGVProfessores.CurrentRow.Cells[0].Value);            
            txtNome.Text = Convert.ToString(dGVProfessores.CurrentRow.Cells[1].Value);
            txtFormacao.Text = Convert.ToString(dGVProfessores.CurrentRow.Cells[2].Value);
            txtSalario.Text = Convert.ToString(dGVProfessores.CurrentRow.Cells[3].Value);
            maskDataInic.Text = Convert.ToString(dGVProfessores.CurrentRow.Cells[4].Value);            
        }
    }
}
