using Microsoft.EntityFrameworkCore;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.DAL
{
    public class CategoriaDAL
    {
        public static async Task<List<Categoria>> GetAll()
        {
            using (var dbContext = new ComunDB())
            {
                return await dbContext.Categorias.ToListAsync();
            }
        }

    
        public static async Task<Categoria> GetById(int id)
        {
            using (var dbContext = new ComunDB())
            {
                return await dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == id);
            }
        }

       
        public static async Task<int> Create(Categoria categoria)
        {
            using (var dbContext = new ComunDB())
            {
                dbContext.Categorias.Add(categoria);
                return await dbContext.SaveChangesAsync();
            }
        }


        public static async Task<int> Update(Categoria categoria)
        {
            using (var dbContext = new ComunDB())
            {
                var existingCategoria = await dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == categoria.Id);

                if (existingCategoria != null)
                {
                    existingCategoria.Nombre = categoria.Nombre;

                    return await dbContext.SaveChangesAsync();
                }

                return 0; 
            }
        }

      
        public static async Task<int> Delete(int id)
        {
            using (var dbContext = new ComunDB())
            {
                var categoria = await dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == id);
                if (categoria != null)
                {
                    dbContext.Categorias.Remove(categoria);
                    return await dbContext.SaveChangesAsync();
                }

                return 0; 
            }
        }
    }
}
