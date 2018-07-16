using AppGestaoEscolar.Model;
using AppGestaoEscolar.Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoEscolar.Controller
{
    public class AlunosController
    {
        Contexto contexto = new Contexto();

        public void Inserir(Aluno aluno)
        {
            contexto.Usuarios_Aluno.Add(aluno);
            contexto.SaveChanges();
        }

        public void Alterar(Aluno aluno)
        {
            contexto.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int idAluno)

        {
            Aluno aluno = BuscarId(idAluno);
            contexto.Usuarios_Aluno.Remove(aluno);
            contexto.SaveChanges();
        }

        public List<Aluno> Listar()
        {
            return contexto.Usuarios_Aluno.ToList();
        }

        public Aluno Buscar(int matricula)
        {
            var aluno = from a in contexto.Usuarios_Aluno
                        where a.Matricula == matricula
                        select a;
            return (Aluno)aluno;
        }

        public Aluno BuscarId(int idAluno)
        {
            return contexto.Usuarios_Aluno.Find(idAluno); 
        }
    }
}
