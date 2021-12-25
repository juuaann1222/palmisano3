using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PalmisanoPromocion.Models;

namespace PalmisanoPromocion.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment env;

        public PeliculasController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this.env = env;
        }

        // GET: Peliculas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Peliculas.Include(p => p.Genero);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Peliculas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas
                .Include(p => p.Genero)
		        .Include(p => p.Actores)
                    .ThenInclude(a => a.Persona)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return View(pelicula);
        }

        // GET: Peliculas/Create
        public IActionResult Create()
        {
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion");
            return View();
        }

        // POST: Peliculas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,FechaEstreno,Foto,Trailer,Resumen,GeneroId,Actores,FotoActores")] Pelicula pelicula)
        {
            
            if (ModelState.IsValid)
            {
                var archivos = HttpContext.Request.Form.Files;
                if (archivos != null && archivos.Count > 0)
                {
                    var imagenArchivo = archivos[0];
                    var pathdestino = Path.Combine(env.WebRootPath, "Pelicula");
                    if (imagenArchivo.Length > 0)
                    {
                        var archivoDestino = Guid.NewGuid().ToString().Replace("-", "") +
                            Path.GetExtension(imagenArchivo.FileName);
                        using (var filestream = new FileStream(Path.Combine(pathdestino, archivoDestino), FileMode.Create))
                        {
                            imagenArchivo.CopyTo(filestream);
                            pelicula.Foto = archivoDestino;
                        };
                    }
                }
                _context.Add(pelicula);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            //if (ModelState.IsValid)
            //{
            //    _context.Add(pelicula);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", pelicula.GeneroId);
            return View(pelicula);
        }

        // GET: Peliculas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula == null)
            {
                return NotFound();
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", pelicula.GeneroId);
            return View(pelicula);
        }

        // POST: Peliculas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,FechaEstreno,Foto,Trailer,Resumen,GeneroId,Actores,FotoActores")] Pelicula pelicula)
        {
            if (id != pelicula.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var archivos = HttpContext.Request.Form.Files;
                if (archivos != null && archivos.Count > 0)
                {
                    var imagenArchivo = archivos[0];
                    var pathdestino = Path.Combine(env.WebRootPath, "Pelicula");
                    if (imagenArchivo.Length > 0)
                    {
                        var archivoDestino = Guid.NewGuid().ToString().Replace("-", "") +
                            Path.GetExtension(imagenArchivo.FileName);
                        using (var filestream = new FileStream(Path.Combine(pathdestino, archivoDestino), FileMode.Create))
                        {
                            imagenArchivo.CopyTo(filestream);

                            string viejoArchivo = Path.Combine(pathdestino, pelicula.Foto ?? "");
                            if (System.IO.File.Exists(viejoArchivo))
                                System.IO.File.Delete(viejoArchivo);
                            pelicula.Foto = archivoDestino;
                        };
                    }
                }
                try
                {
                    _context.Update(pelicula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculaExists(pelicula.Id))
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
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", pelicula.GeneroId);
            return View(pelicula);
        }

        // GET: Peliculas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas
                .Include(p => p.Genero)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return View(pelicula);
        }

        // POST: Peliculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);
            _context.Peliculas.Remove(pelicula);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculaExists(int id)
        {
            return _context.Peliculas.Any(e => e.Id == id);
        }
    }
}
