//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppGestaoEscolar.Model.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public long CPF { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
    }
}
