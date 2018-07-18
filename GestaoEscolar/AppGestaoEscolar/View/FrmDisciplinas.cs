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
        public FrmDisciplinas()
        {
            InitializeComponent();
        }

        private void FrmDisciplinas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'disciplinasDataSet.Disciplinas'. Você pode movê-la ou removê-la conforme necessário.
            this.disciplinasTableAdapter.Fill(this.disciplinasDataSet.Disciplinas);
            // TODO: esta linha de código carrega dados na tabela 'professoresDataSet.Professores'. Você pode movê-la ou removê-la conforme necessário.
            this.professoresTableAdapter.Fill(this.professoresDataSet.Professores); 
        }
    }
}
