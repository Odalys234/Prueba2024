using OdalysEscobar2024.PruebaTecnica.DAL;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.BL
{
    public class ProductoBL
    {
        private readonly ProductoDAL _productoDAL;

        public ProductoBL(ProductoDAL productoDAL)
        {
            _productoDAL = productoDAL;
        }

        
        public async Task<int> CreateProductoAsync(Producto producto)
        {
            return await _productoDAL.CreateProductoAsync(producto);
        }

        
        public async Task<int> EditProductoAsync(Producto producto)
        {
            return await _productoDAL.EditProductoAsync(producto);
        }

       
        public async Task<Producto> GetByIdAsync(int id)
        {
            return await _productoDAL.GetByIdAsync(id);
        }

        
        public async Task<List<Producto>> GetAllAsync()
        {
            return await _productoDAL.GetAllAsync();
        }

        
        public async Task<int> DeleteAsync(int id)
        {
            return await _productoDAL.DeleteAsync(id);
        }
    }
}
