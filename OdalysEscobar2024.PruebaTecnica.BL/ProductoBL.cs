using OdalysEscobar2024.PruebaTecnica.EN; 
using OdalysEscobar2024.PruebaTecnica.DAL; 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.BL
{
    public class ProductosBL
    {

        public static async Task<List<Producto>> GetAll()
        {
            return await ProductosDAL.GetAll();
        }

        
        public static async Task<Producto> GetById(int id)
        {
            return await ProductosDAL.GetById(id);
        }

       
        public static async Task<int> Create(Producto producto)
        {
            return await ProductosDAL.Create(producto);
        }

        
        public static async Task<int> Update(Producto producto)
        {
            return await ProductosDAL.Update(producto);
        }

   
        public static async Task<int> Delete(int id)
        {
            return await ProductosDAL.Delete(id);
        }
    }
}
