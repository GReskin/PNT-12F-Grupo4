using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Context;
using App.Models;

namespace App.Controllers
{
    public class ClaseController : Controller
    {
        private readonly ClasesDatabaseContext _context;

        public ClaseController(ClasesDatabaseContext context)
        {
            _context = context;
        }

        // GET: Clase
        public async Task<IActionResult> Index()
        {
            var clase = _context.Clase.Include(p => p.curso);

            return View(await clase.ToListAsync());
        }

        // GET: Clase/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Clase == null)
            {
                return NotFound();
            }

            var clase = await _context.Clase
                .Include(b => b.curso)
                .FirstOrDefaultAsync(m => m.idClase == id);
            if (clase == null)
            {
                return NotFound();
            }

            return View(clase);
        }

        // GET: Clase/Create
        public IActionResult Create()
        {

            ViewData["idCurso"] = new SelectList(_context.Cursos, "idCurso", "nombreCurso");
            return View();
        }

        // POST: Clase/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idClase,nombreClase,linkVideo,fechaClase,idCurso")] Models.Clase clase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCurso"] = new SelectList(_context.Cursos, "idCurso", "nombreCurso", clase.idCurso);
            return View(clase);
        }

        // GET: Clase/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Clase == null)
            {
                return NotFound();
            }

            var clase = await _context.Clase.FindAsync(id);
            if (clase == null)
            {
                return NotFound();
            }
            ViewData["idCurso"] = new SelectList(_context.Cursos, "idCurso", "nombreCurso", clase.idCurso);
            return View(clase);
        }

        // POST: Clase/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idClase,nombreClase,linkVideo,fechaClase,idCurso")] Models.Clase clase)
        {
            if (id != clase.idClase)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaseExists(clase.idClase))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCurso"] = new SelectList(_context.Cursos, "idCurso", "nombreCurso", clase.idCurso);
            return View(clase);
        }

        // GET: Clase/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Clase == null)
            {
                return NotFound();
            }

            var clase = await _context.Clase
                .FirstOrDefaultAsync(m => m.idClase == id);
            if (clase == null)
            {
                return NotFound();
            }

            return View(clase);
        }

        // POST: Clase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Clase == null)
            {
                return Problem("Entity set 'ClasesDatabaseContext.Clase'  is null.");
            }
            var clase = await _context.Clase.FindAsync(id);
            if (clase != null)
            {
                _context.Clase.Remove(clase);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClaseExists(int id)
        {
          return (_context.Clase?.Any(e => e.idClase == id)).GetValueOrDefault();
        }
    }
}
