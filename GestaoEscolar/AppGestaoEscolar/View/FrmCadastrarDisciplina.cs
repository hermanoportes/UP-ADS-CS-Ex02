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

        private void FrmCadastrarDisciplina_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoEscolarDBDataSet.Disciplinas'. Você pode movê-la ou removê-la conforme necessário.
            this.disciplinasTableAdapter.Fill(this.gestaoEscolarDBDataSet.Disciplinas);
            // TODO: esta linha de código carrega dados na tabela 'gestaoEscolarDBDataSet.Usuarios_Professor'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarios_ProfessorTableAdapter.Fill(this.gestaoEscolarDBDataSet.Usuarios_Professor);
            // TODO: esta linha de código carrega dados na tabela 'gestaoEscolarDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.gestaoEscolarDBDataSet.Usuarios);

        }
    }
}
