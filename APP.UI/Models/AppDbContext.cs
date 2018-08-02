using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace APP.UI.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=WebApps")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<sys_menu> sys_menu { get; set; }
        public virtual DbSet<sys_operation> sys_operation { get; set; }
        public virtual DbSet<sys_permission> sys_permission { get; set; }
        public virtual DbSet<sys_role> sys_role { get; set; }
        public virtual DbSet<sys_role_permission> sys_role_permission { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }
    }
}