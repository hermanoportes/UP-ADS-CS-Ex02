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
        Contexto contexto = new Contexto();

        public void Inserir(Professor professor)
        {
            contexto.Usuarios_Professor.Add(professor);
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
            contexto.Usuarios_Professor.Remove(professor);
            contexto.SaveChanges();
        }

        public List<Professor> Listar()
        {
            return contexto.Usuarios_Professor.ToList();
        }

        public Professor BuscarId(int idProfessor)
        {
            return contexto.Usuarios_Professor.Find(idProfessor);
        }
    }
}
