﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CWProje.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CwProjeEntities : DbContext
    {
        public CwProjeEntities()
            : base("name=CwProjeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Deneyimlerim> Deneyimlerim { get; set; }
        public virtual DbSet<Egitimlerim> Egitimlerim { get; set; }
        public virtual DbSet<Hakkimda> Hakkimda { get; set; }
        public virtual DbSet<Hobilerim> Hobilerim { get; set; }
        public virtual DbSet<iletisim> iletisim { get; set; }
        public virtual DbSet<Sertifikalarim> Sertifikalarim { get; set; }
        public virtual DbSet<Yeteneklerim> Yeteneklerim { get; set; }
    }
}