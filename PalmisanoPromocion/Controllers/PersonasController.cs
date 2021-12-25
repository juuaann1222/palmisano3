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
using PalmisanoPromocion.ViewModel;

namespace PalmisanoPromocion.Controllers
{
    public class PersonasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment env;

        public PersonasController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this.env = env;
        }

        // GET: Personas
        public async Task<IActionResult> Index(int pagina=1)
        {
            PaginadorViewModel paginador = new PaginadorViewModel();
            paginador.PaginaActual = pagina;
            paginador.RegistrosPorPagina = 4;
            paginador.TotalRegistros = await _context.Personas.CountAsync();
            ViewBag.Paginador = paginador;

            //Generar Pagina
            var registrosMostrar = _context.Personas
                .Skip((pagina - 1) * paginador.RegistrosPorPagina)
                .Take(paginador.RegistrosPorPagina);

            return View(await registrosMostrar.ToListAsync());
            //return View(await _context.Personas.ToListAsync());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FechaNacimiento,Biografia,Foto")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                var archivos = HttpContext.Request.Form.Files;
                if (archivos != null && archivos.Count > 0)
                {
                    var imagenArchivo = archivos[0];
                    var pathdestino = Path.Combine(env.WebRootPath, "Persona");
                    if (imagenArchivo.Length > 0)
                    {
                        var archivoDestino = Guid.NewGuid().ToString().Replace("-", "") +
                            Path.GetExtension(imagenArchivo.FileName);
                        using (var filestream = new FileStream(Path.Combine(pathdestino, archivoDestino), FileMode.Create))
                        {
                            imagenArchivo.CopyTo(filestream);
                            persona.Foto = archivoDestino;
                        };
                    }
                }
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FechaNacimiento,Biografia,Foto")] Persona persona)
        {
            if (id != persona.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var archivos = HttpContext.Request.Form.Files;
                if (archivos != null && archivos.Count > 0)
                {
                    var imagenArchivo = archivos[0];
                    var pathdestino = Path.Combine(env.WebRootPath, "Actor");
                    if (imagenArchivo.Length > 0)
                    {
                        var archivoDestino = Guid.NewGuid().ToString().Replace("-", "") +
                            Path.GetExtension(imagenArchivo.FileName);
                        using (var filestream = new FileStream(Path.Combine(pathdestino, archivoDestino), FileMode.Create))
                        {
                            imagenArchivo.CopyTo(filestream);

                            string viejoArchivo = Path.Combine(pathdestino, persona.Foto ?? "");
                            if (System.IO.File.Exists(viejoArchivo))
                                System.IO.File.Delete(viejoArchivo);
                            persona.Foto = archivoDestino;
                        };
                    }
                }
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.Id))
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
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.Personas.Any(e => e.Id == id);
        }
    }
}
