using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EntityFrameworkNetCore_6.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           // SeedingInicial.Seed(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }

        public DbSet<Categoria> Categoria => Set<Categoria>();
        public DbSet<Producto> Producto => Set<Producto>();
        public DbSet<Cab_Movimiento> Cab_Movimiento => Set<Cab_Movimiento>();
        public DbSet<Det_Movimiento> Det_Movimiento => Set<Det_Movimiento>();
        public DbSet<Persona> Persona => Set<Persona>();
        public DbSet<Tipo_Movimiento> Tipo_Movimiento => Set<Tipo_Movimiento>();
        public DbSet<Usuario> Usuario => Set<Usuario>();


    }
}
