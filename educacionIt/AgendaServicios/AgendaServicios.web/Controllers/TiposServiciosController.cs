﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgendaServicios.web.Models;

namespace AgendaServicios.web.Controllers
{
    public class TiposServiciosController : Controller
    {
        private readonly TurnosDbContext _context;

        public TiposServiciosController(TurnosDbContext context)
        {
            _context = context;
        }

        // GET: TiposServicios
        public async Task<IActionResult> Index()
        {
              return _context.TipoServicios != null ? 
                          View(await _context.TipoServicios.ToListAsync()) :
                          Problem("Entity set 'TurnosDbContext.TipoServicios'  is null.");
        }

        // GET: TiposServicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoServicios == null)
            {
                return NotFound();
            }

            var tipoServicio = await _context.TipoServicios
                .FirstOrDefaultAsync(m => m.TipoServicioId == id);
            if (tipoServicio == null)
            {
                return NotFound();
            }

            return View(tipoServicio);
        }

        // GET: TiposServicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposServicios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoServicioId,Descripcion")] TipoServicio tipoServicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoServicio);
        }

        // GET: TiposServicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoServicios == null)
            {
                return NotFound();
            }

            var tipoServicio = await _context.TipoServicios.FindAsync(id);
            if (tipoServicio == null)
            {
                return NotFound();
            }
            return View(tipoServicio);
        }

        // POST: TiposServicios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoServicioId,Descripcion")] TipoServicio tipoServicio)
        {
            if (id != tipoServicio.TipoServicioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoServicioExists(tipoServicio.TipoServicioId))
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
            return View(tipoServicio);
        }

        // GET: TiposServicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoServicios == null)
            {
                return NotFound();
            }

            var tipoServicio = await _context.TipoServicios
                .FirstOrDefaultAsync(m => m.TipoServicioId == id);
            if (tipoServicio == null)
            {
                return NotFound();
            }

            return View(tipoServicio);
        }

        // POST: TiposServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TipoServicios == null)
            {
                return Problem("Entity set 'TurnosDbContext.TipoServicios'  is null.");
            }
            var tipoServicio = await _context.TipoServicios.FindAsync(id);
            if (tipoServicio != null)
            {
                _context.TipoServicios.Remove(tipoServicio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoServicioExists(int id)
        {
          return (_context.TipoServicios?.Any(e => e.TipoServicioId == id)).GetValueOrDefault();
        }
    }
}
