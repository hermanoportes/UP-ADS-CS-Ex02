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
    public partial class FrmBuscaProfessor : Form
    {
        public string professorId;
        public string professorNome;

        public FrmBuscaProfessor()
        {
            InitializeComponent();
        }

        private void FrmBuscaProfessor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'professoresDataSet.Professores'. Você pode movê-la ou removê-la conforme necessário.
            this.professoresTableAdapter.Fill(this.professoresDataSet.Professores);

        }

        private void dGVListaProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.professorId = Convert.ToString(dGVListaProfessores.CurrentRow.Cells[0].Value);
            this.professorNome = Convert.ToString(dGVListaProfessores.CurrentRow.Cells[1].Value);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            this.Close();
        }        
    }
}
