﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parcial1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ITMEntities : DbContext
    {
        public ITMEntities()
            : base("name=ITMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agencia> Agencias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Computador> Computadors { get; set; }
        public virtual DbSet<TipoComputador> TipoComputadors { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
    }
}
