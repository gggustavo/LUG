using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Context : DbContext
    {
        public Context()
            : base("name=Default")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Cuenta>().HasKey(_ => _.IdCuenta);
            
            modelBuilder.Entity<Titular>().HasKey(_ => _.IdTitular);

            modelBuilder.Entity<Cuenta>().HasRequired(_ => _.Titular);

        }

        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Titular> Titulares { get; set; }

    }
}
