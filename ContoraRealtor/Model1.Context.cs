﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContoraRealtor
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RealtorEntities : DbContext
    {
        public RealtorEntities()
            : base("name=RealtorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adress> Adress { get; set; }
        public virtual DbSet<Apartment> Apartment { get; set; }
        public virtual DbSet<ApartmentDemand> ApartmentDemand { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Coordinates> Coordinates { get; set; }
        public virtual DbSet<Deal> Deal { get; set; }
        public virtual DbSet<demand> demand { get; set; }
        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<HouseDemand> HouseDemand { get; set; }
        public virtual DbSet<Land> Land { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<property> property { get; set; }
        public virtual DbSet<Realtor> Realtor { get; set; }
        public virtual DbSet<Sentence> Sentence { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<LandDemand> LandDemand { get; set; }
    }
}
