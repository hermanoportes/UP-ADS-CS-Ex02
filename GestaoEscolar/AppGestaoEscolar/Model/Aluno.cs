using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoEscolar.Model
{
    public class Aluno : Usuario
    {
        public int Matricula { get; set; }
        public int Idade { get; set; }

    }
}
