using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdalysEscobar2024.PruebaTecnica.BL;
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.UI.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductosBL _productosBL;
        private readonly CategoriasBL _categoriasBL;

        public ProductoController(ProductosBL productosBL, CategoriasBL categoriasBL)
        {
            _productosBL = productosBL;
            _categoriasBL = categoriasBL;
        }

        // GET: ProductoController
        public async Task<IActionResult> Index()
        {
            var productos = await _productosBL.GetAll();
            return View(productos);
        }

        // GET: ProductoController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var producto = await _productosBL.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

     public async Task<IActionResult> Create()
{
    ViewBag.Categorias = new SelectList(await _categoriasBL.GetAll(), "Id", "Nombre");
    return View();
}

[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create(Producto producto)
{
    if (!ModelState.IsValid)
    {
        ViewBag.Categorias = new SelectList(await _categoriasBL.GetAll(), "Id", "Nombre");
        return View(producto);
    }

    try
    {
        await _productosBL.Create(producto);
        return RedirectToAction(nameof(Index));
    }
    catch (Exception ex)
    {
        ModelState.AddModelError(string.Empty, $"Error al crear el producto: {ex.Message}");
        ViewBag.Categorias = new SelectList(await _categoriasBL.GetAll(), "Id", "Nombre");
        return View(producto);
    }
}

public async Task<IActionResult> Edit(int id)
{
    var producto = await _productosBL.GetById(id);
    if (producto == null) return NotFound();

    ViewBag.Categorias = new SelectList(await _categoriasBL.GetAll(), "Id", "Nombre", producto.IdCategoria);
    return View(producto);
}

[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(int id, Producto producto)
{
    if (id != producto.Id) return BadRequest();

    if (!ModelState.IsValid)
    {
        ViewBag.Categorias = new SelectList(await _categoriasBL.GetAll(), "Id", "Nombre", producto.IdCategoria);
        return View(producto);
    }

    try
    {
        await _productosBL.Update(producto);
        return RedirectToAction(nameof(Index));
    }
    catch (Exception ex)
    {
        ModelState.AddModelError(string.Empty, $"Error al editar el producto: {ex.Message}");
        ViewBag.Categorias = new SelectList(await _categoriasBL.GetAll(), "Id", "Nombre", producto.IdCategoria);
        return View(producto);
    }
}


        // GET: ProductoController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _productosBL.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: ProductoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletet(int id)
        {
            try
            {
                await _productosBL.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
