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
    
    public partial class Ingressos
    {
        public Ingressos()
        {
            this.Venda = new HashSet<Venda>();
        }
    
        public int ing_id { get; set; }
        public Nullable<decimal> ing_preco { get; set; }
        public int fil_id { get; set; }
        public int sal_id { get; set; }
        public int ses_id { get; set; }
        public int tin_id { get; set; }
    
        public virtual Filme Filme { get; set; }
        public virtual Salas Salas { get; set; }
        public virtual Sessoes Sessoes { get; set; }
        public virtual TiposIngresso TiposIngresso { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
