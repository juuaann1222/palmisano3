using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PalmisanoPromocion.Models;

namespace PalmisanoPromocion.Controllers
{
    public class PeliculasActoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeliculasActoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PeliculasActores
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.peliculasActores.Include(p => p.Pelicula).Include(p => p.Persona);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PeliculasActores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaActor = await _context.peliculasActores
                .Include(p => p.Pelicula)
                .Include(p => p.Persona)
                .FirstOrDefaultAsync(m => m.PeliculaId == id);
            if (peliculaActor == null)
            {
                return NotFound();
            }

            return View(peliculaActor);
        }

        // GET: PeliculasActores/Create
        public IActionResult Create()
        {
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo");
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Nombre");
            return View();
        }

        // POST: PeliculasActores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PeliculaId,PersonaId")] PeliculaActor peliculaActor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(peliculaActor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", peliculaActor.PeliculaId);
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Nombre", peliculaActor.PersonaId);
            return View(peliculaActor);
        }

        // GET: PeliculasActores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaActor = await _context.peliculasActores.FindAsync(id);
            if (peliculaActor == null)
            {
                return NotFound();
            }
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", peliculaActor.PeliculaId);
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Nombre", peliculaActor.PersonaId);
            return View(peliculaActor);
        }

        // POST: PeliculasActores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PeliculaId,PersonaId")] PeliculaActor peliculaActor)
        {
            if (id != peliculaActor.PeliculaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(peliculaActor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculaActorExists(peliculaActor.PeliculaId))
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
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", peliculaActor.PeliculaId);
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Nombre", peliculaActor.PersonaId);
            return View(peliculaActor);
        }

        // GET: PeliculasActores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaActor = await _context.peliculasActores
                .Include(p => p.Pelicula)
                .Include(p => p.Persona)
                .FirstOrDefaultAsync(m => m.PeliculaId == id);
            if (peliculaActor == null)
            {
                return NotFound();
            }

            return View(peliculaActor);
        }

        // POST: PeliculasActores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var peliculaActor = await _context.peliculasActores.FindAsync(id);
            _context.peliculasActores.Remove(peliculaActor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculaActorExists(int id)
        {
            return _context.peliculasActores.Any(e => e.PeliculaId == id);
        }
    }
}
