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
    public partial class FrmCadastrarDisciplina : Form
    {
        public FrmCadastrarDisciplina()
        {
            InitializeComponent();
        }        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina();

            disciplina.Nome = txtNomeDisc.Text;
            disciplina.CargaHoraria = int.Parse(txtCH.Text);
            //disciplina.ProfessorId = comboProfessorId.;
        }
    }
}
