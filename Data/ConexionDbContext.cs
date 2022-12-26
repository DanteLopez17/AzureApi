using AzureApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AzureApi.Data
{
    public class ConexionDbContext : DbContext
    {
        protected readonly IConfiguration _configuracion;
        public ConexionDbContext(IConfiguration configuracion)
        {
            _configuracion = configuracion;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuracion.GetConnectionString("MiConexion"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable(tb => tb.HasTrigger("InsertNewCliente"));
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteListo> ClienteListo { get; set; }
        public DbSet<ClienteNuevo> ClienteNuevo { get; set; }
    }
}
