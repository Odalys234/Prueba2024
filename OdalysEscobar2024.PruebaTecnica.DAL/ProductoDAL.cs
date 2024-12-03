using Microsoft.EntityFrameworkCore;
using OdalysEscobar2024.PruebaTecnica.DAL;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.DAL
{
    public class ProductosDAL
    {
        /*
               public static async Task<List<Producto>> GetAll()
               {
                   using (var dbContext = new ComunDB())
                   {
                       return await dbContext.Productos.Include(p => p.Categorias).ToListAsync();
                   }
               }


               public static async Task<Producto> GetById(int id)
               {
                   using (var dbContext = new ComunDB())
                   {
                       return await dbContext.Productos.Include(p => p.Categorias)
                                                       .FirstOrDefaultAsync(p => p.Id == id);
                   }
               }


               public static async Task<int> Create(Producto producto)
               {
                   using (var dbContext = new ComunDB())
                   {
                       dbContext.Productos.Add(producto);
                       return await dbContext.SaveChangesAsync();
                   }
               }

               public static async Task<int> Update(Producto producto)
               {
                   using (var dbContext = new ComunDB())
                   {
                       var existingProducto = await dbContext.Productos.FirstOrDefaultAsync(p => p.Id == producto.Id);

                       if (existingProducto != null)
                       {
                           existingProducto.Nombre = producto.Nombre;
                           existingProducto.Precio = producto.Precio;
                           existingProducto.IdCategoria = producto.IdCategoria;

                           return await dbContext.SaveChangesAsync();
                       }

                       return 0; 
                   }
               }


               public static async Task<int> Delete(int id)
               {
                   using (var dbContext = new ComunDB())
                   {
                       var producto = await dbContext.Productos.FirstOrDefaultAsync(p => p.Id == id);
                       if (producto != null)
                       {
                           dbContext.Productos.Remove(producto);
                           return await dbContext.SaveChangesAsync();
                       }

                       return 0; 
                   }
               }
           }*/
    }
}
