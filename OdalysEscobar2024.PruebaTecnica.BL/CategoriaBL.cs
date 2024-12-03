using OdalysEscobar2024.PruebaTecnica.DAL;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.BL
{
    public class CategoriasBL
    {
        private readonly CategoriaDAL _categoriaDAL;

        public CategoriasBL(CategoriaDAL categoriaDAL)
        {
            _categoriaDAL = categoriaDAL;
        }

        public async Task<List<Categoria>> GetAll()
        {
            return await _categoriaDAL.GetAll();
        }

        public async Task<Categoria> GetById(int id)
        {
            return await _categoriaDAL.GetById(id);
        }

        public async Task<int> Create(Categoria categoria)
        {
            return await _categoriaDAL.Create(categoria);
        }

        public async Task<int> Update(Categoria categoria)
        {
            return await _categoriaDAL.Update(categoria);
        }

        public async Task<int> Delete(int id)
        {
            return await _categoriaDAL.Delete(id);
        }
    }
}
