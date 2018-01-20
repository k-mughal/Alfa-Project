using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using LoginSys.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LoginSys.DAL
{
    public class LoginSysContext : DbContext
    {
        public LoginSysContext() : base ("LoginSysContext")
        {
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<EmpBranch> EmpBranch { get; set; }
        public DbSet<Employees> Employees { get; set; }

        public DbSet<Role> Roll { get; set; }
        public DbSet<EmpRole> EmpRoles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); }

    }
}