﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BorsaProjesiAraSinav
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<KullaniciTalep> KullaniciTalepleri { get; set; }
        public virtual DbSet<KullaniciUrun> KullaniciUrunleri { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Talep> Talepler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
    }
}
