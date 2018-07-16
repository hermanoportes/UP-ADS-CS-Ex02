using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoEscolar.Model.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("GestaoEscolarDB")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Usuarios_Aluno { get; set; }
        public DbSet<Professor> Usuarios_Professor { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
}
}
