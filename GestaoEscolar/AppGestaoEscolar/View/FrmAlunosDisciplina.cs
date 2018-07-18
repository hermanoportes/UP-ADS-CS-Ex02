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
    public partial class FrmAlunosDisciplina : Form
    {
        public int disciplinaId { get; set; }
        //public virtual ICollection<Aluno> alunoDisciplinas { get; set; }
        //public virtual ICollection<Disciplina> disciplinaAlunos{ get; set; }

        public FrmAlunosDisciplina()
        {
            InitializeComponent();
        }

        private void FrmAlunosDisciplina_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'alunosDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.alunosDataSet.Alunos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Id = int.Parse(Convert.ToString(dGVListaAlunos.CurrentRow.Cells[0].Value));
            aluno.Matricula = int.Parse(Convert.ToString(dGVListaAlunos.CurrentRow.Cells[1].Value));
            aluno.Nome = Convert.ToString(dGVListaAlunos.CurrentRow.Cells[2].Value);
            aluno.DataNasc = Convert.ToString(dGVListaAlunos.CurrentRow.Cells[3].Value);
            aluno.Sexo = Convert.ToString(dGVListaAlunos.CurrentRow.Cells[3].Value);
            
            
            


        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
