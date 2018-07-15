﻿using Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AlunosController
    {
        GestaoEscolarDBContext contexto = new GestaoEscolarDBContext();

        public void Inserir(Aluno aluno)
        {
            contexto.Alunos.Add(aluno);
            contexto.SaveChanges();
        }

        public void Alterar(int matricula)
        {
            ContextStaticAttribute.En
        }

        public void Excluir(int matricula)
        {
            
        }

        public List<Aluno> Listar()
        {
            return contexto.Alunos.ToList();
        }

        public Aluno Buscar(int matricula)
        {
            var aluno = from a in contexto.Alunos
                        where a.Matricula == matricula
                        select a;
            return (Aluno)aluno;
        }
    }
}
