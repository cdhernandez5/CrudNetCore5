using CrudNetCore5.Data;
using CrudNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CrudNetCore5.Controllers
{
    /// <summary>
    /// Clase controlador libro.
    /// </summary>
    public class LibrosController : Controller
    {
        /// <summary>
        /// Permite acceder a la base de datos.
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="context"></param>
        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Vista principal de los libros.
        /// </summary>
        public IActionResult Index()
        {
            IEnumerable<Libro> listaLibros = _context.Libro; 
            return View(listaLibros);
        }

        /// <summary>
        /// Retonra vista con el libro a editar.
        /// </summary>
        /// <param name="id">Identificador del libro</param>
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }
               
        /// <summary>
        /// Retorna la vista para crear un libro.
        /// </summary>
        public IActionResult Create()
        {            
            return View();
        }

        /// <summary>
        /// Ejecuta la acción para crear un libro.
        /// </summary>
        /// <param name="libro">Información del nuevo libro.</param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();
                TempData["Mensaje"] = "Libro guardado correctamente.";
                return RedirectToAction("Index");
            }
            return View();
        }

        /// <summary>
        /// Ejecuta la acción para editar un libro.
        /// </summary>
        /// <param name="libro">infomración del libro.</param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Update(libro);
                _context.SaveChanges();
                TempData["Mensaje"] = "Libro se actualizó correctamente.";
                return RedirectToAction("Index");
            }
            return View();
        }

        /// <summary>
        /// Carga la vista para eliminar un libro.
        /// </summary>
        /// <param name="id">Id del libro</param>
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        /// <summary>
        /// Ejecuta la acción para eliminar un libro.
        /// </summary>
        /// <param name="id">Id del libro.</param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(int? id)
        {
            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            _context.Libro.Remove(libro);
            _context.SaveChanges();

            TempData["Mensaje"] = "El Libro se eliminó correctamente.";
            return RedirectToAction("Index");
        }
    }
}
