﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CinemaEntities : DbContext
    {
        public CinemaEntities()
            : base("name=CinemaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Filme> Filme { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Ingressos> Ingressos { get; set; }
        public virtual DbSet<ItensVenda> ItensVenda { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Salas> Salas { get; set; }
        public virtual DbSet<Sessoes> Sessoes { get; set; }
        public virtual DbSet<TiposIngresso> TiposIngresso { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }
    }
}
