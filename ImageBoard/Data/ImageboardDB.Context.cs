﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageBoard.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class imageboardEntities : DbContext
    {
        public imageboardEntities()
            : base("name=imageboardEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<postlike> postlikes { get; set; }
        public virtual DbSet<subboardpostjoin> subboardpostjoins { get; set; }
        public virtual DbSet<subboard> subboards { get; set; }
        public virtual DbSet<subboardusersub> subboardusersubs { get; set; }
    }
}
