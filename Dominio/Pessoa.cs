//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        public int pes_id { get; set; }
        public string pes_nome { get; set; }
        public Nullable<System.DateTime> pes_datanasc { get; set; }
        public string pes_cpf { get; set; }
        public int cli_id { get; set; }
        public int fun_id { get; set; }
        public Nullable<int> pes_telefone { get; set; }
        public string pes_login { get; set; }
        public string pes_senha { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
