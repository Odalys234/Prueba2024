using Microsoft.EntityFrameworkCore;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.DAL
{
    public class CategoriaDAL
    {
        private readonly ComunDB _dbContext;

        public CategoriaDAL(ComunDB dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Categoria>> GetAll()
        {
            return await _dbContext.Categorias.ToListAsync();
        }

        public async Task<Categoria> GetById(int id)
        {
            return await _dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<int> Create(Categoria categoria)
        {
            _dbContext.Categorias.Add(categoria);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Categoria categoria)
        {
            var existingCategoria = await _dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == categoria.Id);

            if (existingCategoria != null)
            {
                existingCategoria.Nombre = categoria.Nombre;

                return await _dbContext.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<int> Delete(int id)
        {
            var categoria = await _dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == id);
            if (categoria != null)
            {
                _dbContext.Categorias.Remove(categoria);
                return await _dbContext.SaveChangesAsync();
            }

            return 0;
        }
    }
}
