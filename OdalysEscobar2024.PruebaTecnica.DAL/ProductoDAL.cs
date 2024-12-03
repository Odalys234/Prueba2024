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

        public async Task<List<Producto>> GetAll()
        {
            return await _dbContext.Productos
                .Include(p => p.Categorias) 
                .ToListAsync();
        }

        public async Task<Producto> GetById(int id)
        {
            return await _dbContext.Productos
                .Include(p => p.Categorias) 
                .FirstOrDefaultAsync(p => p.Id == id);
        }

      public async Task<int> Create(Producto producto)
{
    var categoria = await _dbContext.Categorias.FindAsync(producto.IdCategoria);
    if (categoria == null) throw new Exception("La categoría no existe.");

    _dbContext.Productos.Add(producto);
    return await _dbContext.SaveChangesAsync();
}

public async Task<int> Update(Producto producto)
{
    var existingProducto = await _dbContext.Productos
        .FirstOrDefaultAsync(p => p.Id == producto.Id);

    if (existingProducto == null) throw new Exception("El producto no existe.");

    existingProducto.Nombre = producto.Nombre;
    existingProducto.Precio = producto.Precio;

    var categoria = await _dbContext.Categorias.FindAsync(producto.IdCategoria);
    if (categoria == null) throw new Exception("La categoría no existe.");
    
    existingProducto.IdCategoria = producto.IdCategoria;

    return await _dbContext.SaveChangesAsync();
}
        public async Task<int> Delete(int id)
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
