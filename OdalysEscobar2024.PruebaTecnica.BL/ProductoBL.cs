using OdalysEscobar2024.PruebaTecnica.DAL;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.BL
{
    public class ProductosBL
    {
        private readonly ProductoDAL _productoDAL;

        public ProductosBL(ProductoDAL productoDAL)
        {
            _productoDAL = productoDAL;
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _productoDAL.GetAll();
        }

        public async Task<Producto> GetById(int id)
        {
            return await _productoDAL.GetById(id);
        }

        public async Task<int> Create(Producto producto)
        {
            return await _productoDAL.Create(producto);
        }

        public async Task<int> Update(Producto producto)
        {
            return await _productoDAL.Update(producto);
        }

        public async Task<int> Delete(int id)
        {
            return await _productoDAL.Delete(id);
        }
    }
}
