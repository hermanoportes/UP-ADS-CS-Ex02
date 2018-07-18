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
        public FrmAlunosDisciplina()
        {
            InitializeComponent();
        }

        private void FrmAlunosDisciplina_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'alunosDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.alunosDataSet.Alunos);

        }
    }
}
