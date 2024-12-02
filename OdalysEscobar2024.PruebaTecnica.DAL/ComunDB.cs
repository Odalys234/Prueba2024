using Microsoft.EntityFrameworkCore;
using OdalysEscobar2024.PruebaTecnica.EN;


namespace OdalysEscobar2024.PruebaTecnica.DAL
{
    public class ComunDB : DbContext
    {
      
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4TMNANE;Initial Catalog=OdalysPrueba2024;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
