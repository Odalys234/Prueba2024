using Microsoft.EntityFrameworkCore;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.DAL
{
    public class ProductoDAL
    {
        private readonly ComunDB _dbContext;

        public ProductoDAL(ComunDB dbContext)
        {
            _dbContext = dbContext;
        }

        
        public async Task<int> CreateProductoAsync(Producto producto)
        {
            _dbContext.Productos.Add(producto);
            return await _dbContext.SaveChangesAsync();
        }

        
        public async Task<int> EditProductoAsync(Producto producto)
        {
            var existingProducto = await _dbContext.Productos.FirstOrDefaultAsync(p => p.Id == producto.Id);
            if (existingProducto != null)
            {
                existingProducto.Nombre = producto.Nombre;
                existingProducto.Precio = producto.Precio;
                existingProducto.IdCategoria = producto.IdCategoria;

                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }

        
        public async Task<Producto> GetByIdAsync(int id)
        {
            return await _dbContext.Productos
                .Include(p => p.Categorias) 
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        
        public async Task<List<Producto>> GetAllAsync()
        {
            return await _dbContext.Productos
                .Include(p => p.Categorias) 
                .ToListAsync();
        }

        
        public async Task<int> DeleteAsync(int id)
        {
            var producto = await _dbContext.Productos.FirstOrDefaultAsync(p => p.Id == id);
            if (producto != null)
            {
                _dbContext.Productos.Remove(producto);
                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
    }
}
