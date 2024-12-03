using Microsoft.EntityFrameworkCore;
using OdalysEscobar2024.PruebaTecnica.EN;


namespace OdalysEscobar2024.PruebaTecnica.DAL
{
    public class ComunDB : DbContext
    {
        public ComunDB(DbContextOptions<ComunDB> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Producto>()
        .HasOne(p => p.Categorias)
        .WithMany()
        .HasForeignKey(p => p.IdCategoria);
       

    base.OnModelCreating(modelBuilder);
}

    }



}

