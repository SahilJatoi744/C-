﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nadroga_Arya_College.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NADROGA_ARYA_COLLEGEEntities : DbContext
    {
        public NADROGA_ARYA_COLLEGEEntities()
            : base("name=NADROGA_ARYA_COLLEGEEntities")
            
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adminlogin> adminlogins { get; set; }
        public virtual DbSet<login> logins { get; set; }
        public virtual DbSet<mst_question> mst_question { get; set; }
        public virtual DbSet<mst_subject> mst_subject { get; set; }
        public virtual DbSet<mst_test> mst_test { get; set; }
        public virtual DbSet<mst_user> mst_user { get; set; }
        public virtual DbSet<@new> news { get; set; }
        public virtual DbSet<pintest> pintests { get; set; }
        public virtual DbSet<question> questions { get; set; }
        public virtual DbSet<regcode> regcodes { get; set; }
        public virtual DbSet<studentreg> studentregs { get; set; }
        public virtual DbSet<timer> timers { get; set; }
        public virtual DbSet<suggest> suggests { get; set; }

    }
}