using AppGestaoEscolar.Model;
using AppGestaoEscolar.Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoEscolar.Controller
{
    public class DisciplinasController
    {
        Model1Container contexto = new Model1Container();

        public void Inserir(Disciplina disciplina)
        {
            contexto.Disciplinas.Add(disciplina);
            contexto.SaveChanges();
        }

        public void Alterar(Disciplina disciplina)
        {
            contexto.Entry(disciplina).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void InserirAluno()
        {

        }

        public void ExcluirAluno()
        {

        }

        public void Excluir(int idDisciplina)

        {
            Disciplina disciplina = BuscarId(idDisciplina);
            contexto.Disciplinas.Remove(disciplina);
            contexto.SaveChanges();
        }

        public List<Disciplina> Listar()
        {
            return contexto.Disciplinas.ToList();
        }

        public Disciplina BuscarId(int idDisciplina)
        {
            return contexto.Disciplinas.Find(idDisciplina);
        }
    }
}
