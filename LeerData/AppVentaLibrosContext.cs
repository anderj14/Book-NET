using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaLibrosContext : DbContext
    {
        private const string connectionString = @"Data Source=DESKTOP-ATI7PB7; Initial Catalog=LibrosWeb; Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        //Validar mas de una llave primaria en una entidad
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<LibroAutor>().HasKey(xi => new {xi.AutorId, xi.LibroId});
        }

        public DbSet<Libro> Libro {get; set;}
        public DbSet<Precio> Precio {get; set;}
        public DbSet<Comentario> Comentario {get; set;}
        public DbSet<Autor> Autor {get; set;}
        public DbSet<LibroAutor> LibroAutor { get; set; }
    }
}