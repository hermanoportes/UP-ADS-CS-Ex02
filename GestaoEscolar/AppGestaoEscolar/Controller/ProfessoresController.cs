using AppGestaoEscolar.Model;
using AppGestaoEscolar.Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoEscolar.Controller
{
    public class ProfessoresController
    {
        static Model1Container contexto = new Model1Container();

        public void Inserir(Professor professor)
        {
            contexto.Professores.Add(professor);
            contexto.SaveChanges();
        }

        public void Alterar(Professor professor)
        {
            contexto.Entry(professor).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int idProfessor)

        {
            Professor professor = BuscarId(idProfessor);
            contexto.Professores.Remove(professor);
            contexto.SaveChanges();
        }

        public List<Professor> Listar()
        {
            return contexto.Professores.ToList();
        }

        public Professor BuscarId(int idProfessor)
        {
            return contexto.Professores.Find(idProfessor);
        }
    }
}
