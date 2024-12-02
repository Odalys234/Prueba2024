using Microsoft.AspNetCore.Mvc;
using OdalysEscobar2024.PruebaTecnica.BL; 
using OdalysEscobar2024.PruebaTecnica.EN;
using System.Threading.Tasks;

namespace OdalysEscobar2024.PruebaTecnica.UI.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: CategoriaController
        public async Task<IActionResult> Index()
        {
            var categorias = await CategoriasBL.GetAll();
            return View(categorias);
        }

        // GET: CategoriaController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var categoria = await CategoriasBL.GetById(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        // GET: CategoriaController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categoria categoria)
        {
            try
            {
                await CategoriasBL.Create(categoria);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var categoria = await CategoriasBL.GetById(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Categoria categoria)
        {
            try
            {
                var categoriaToUpdate = await CategoriasBL.GetById(id);
                if (categoriaToUpdate == null)
                {
                    return NotFound();
                }

                // Actualizar los datos de la categoría
                categoriaToUpdate.Nombre = categoria.Nombre;

                await CategoriasBL.Update(categoriaToUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var categoria = await CategoriasBL.GetById(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        // POST: CategoriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Categoria categoria)
        {
            try
            {
                await CategoriasBL.Delete(categoria.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
