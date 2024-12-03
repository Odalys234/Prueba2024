using Microsoft.AspNetCore.Mvc;
using OdalysEscobar2024.PruebaTecnica.BL;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.UI.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoBL _productoBL;

        public ProductoController(ProductoBL productoBL)
        {
            _productoBL = productoBL;
        }

        
        public async Task<IActionResult> Index()
        {
            var productos = await _productoBL.GetAllAsync();
            return View(productos);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre))
            {
                ModelState.AddModelError("Nombre", "El nombre del producto es obligatorio.");
                return View(producto);
            }

            await _productoBL.CreateProductoAsync(producto);
            return RedirectToAction(nameof(Index));
        }

       
        public async Task<IActionResult> Edit(int id)
        {
            var producto = await _productoBL.GetByIdAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre))
            {
                ModelState.AddModelError("Nombre", "El nombre del producto es obligatorio.");
                return View(producto);
            }

            await _productoBL.EditProductoAsync(producto);
            return RedirectToAction(nameof(Index));
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _productoBL.GetByIdAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productoBL.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var producto = await _productoBL.GetByIdAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }
    }
}
