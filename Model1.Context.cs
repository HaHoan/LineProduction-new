﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Line_Production
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class barcode_dbEntities : DbContext
    {
        public barcode_dbEntities()
            : base("name=barcode_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HondaLock> HondaLocks { get; set; }
        public virtual DbSet<LINE_MODEL> LINE_MODEL { get; set; }
        public virtual DbSet<LINE_PASSRATE> LINE_PASSRATE { get; set; }
        public virtual DbSet<LINE_TIME> LINE_TIME { get; set; }
        public virtual DbSet<LINE_TIMELINE> LINE_TIMELINE { get; set; }
    }
}