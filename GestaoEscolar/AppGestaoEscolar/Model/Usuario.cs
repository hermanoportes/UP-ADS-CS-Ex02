using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoEscolar.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public Int64 CPF { get; set; }
        public Int64 Telefone{ get; set; }
        public string Endereco { get; set; }
    }
}
