using OdalysEscobar2024.PruebaTecnica.DAL;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.BL
{
    public class CategoriasBL
    {
        
        public static async Task<List<Categoria>> GetAll()
        {
            return await CategoriaDAL.GetAll();
        }

      
        public static async Task<Categoria> GetById(int id)
        {
            return await CategoriaDAL.GetById(id);
        }

       
        public static async Task<int> Create(Categoria categoria)
        {
            return await CategoriaDAL.Create(categoria);
        }

        
        public static async Task<int> Update(Categoria categoria)
        {
            return await CategoriaDAL.Update(categoria);
        }

      
        public static async Task<int> Delete(int id)
        {
            return await CategoriaDAL.Delete(id);
        }
    }
}
