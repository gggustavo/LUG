using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

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


            
            modelBuilder.Entity<Cuenta>().HasMany(_ => _.Titular)
                                         .WithMany(_ => _.Cuentas)
                                         .Map(_ => _.MapLeftKey("IdCuenta")
                                                    .MapRightKey("IdTitular")
                                                    .ToTable("CuentaTitular"));
            

        }

        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Titular> Titulares { get; set; }

    }
}
