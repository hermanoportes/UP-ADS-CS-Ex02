using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoEscolar.Model
{
    public class Professor : Usuario
    {
        public string Formacao { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataInicio { get; set; }
    }
}
