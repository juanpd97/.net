using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgendaServicios.web.Models;

namespace AgendaServicios.web.Controllers
{
    public class EstadosTurnosController : Controller
    {
        private readonly TurnosDbContext _context;

        public EstadosTurnosController(TurnosDbContext context)
        {
            _context = context;
        }

        // GET: EstadosTurnos
        public async Task<IActionResult> Index()
        {
              return _context.EstadoTurnos != null ? 
                          View(await _context.EstadoTurnos.ToListAsync()) :
                          Problem("Entity set 'TurnosDbContext.EstadoTurnos'  is null.");
        }

        // GET: EstadosTurnos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EstadoTurnos == null)
            {
                return NotFound();
            }

            var estadoTurno = await _context.EstadoTurnos
                .FirstOrDefaultAsync(m => m.EstadoTurnoId == id);
            if (estadoTurno == null)
            {
                return NotFound();
            }

            return View(estadoTurno);
        }

        // GET: EstadosTurnos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadosTurnos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstadoTurnoId,Descripcion")] EstadoTurno estadoTurno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoTurno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadoTurno);
        }

        // GET: EstadosTurnos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EstadoTurnos == null)
            {
                return NotFound();
            }

            var estadoTurno = await _context.EstadoTurnos.FindAsync(id);
            if (estadoTurno == null)
            {
                return NotFound();
            }
            return View(estadoTurno);
        }

        // POST: EstadosTurnos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstadoTurnoId,Descripcion")] EstadoTurno estadoTurno)
        {
            if (id != estadoTurno.EstadoTurnoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoTurno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoTurnoExists(estadoTurno.EstadoTurnoId))
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
            return View(estadoTurno);
        }

        // GET: EstadosTurnos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EstadoTurnos == null)
            {
                return NotFound();
            }

            var estadoTurno = await _context.EstadoTurnos
                .FirstOrDefaultAsync(m => m.EstadoTurnoId == id);
            if (estadoTurno == null)
            {
                return NotFound();
            }

            return View(estadoTurno);
        }

        // POST: EstadosTurnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EstadoTurnos == null)
            {
                return Problem("Entity set 'TurnosDbContext.EstadoTurnos'  is null.");
            }
            var estadoTurno = await _context.EstadoTurnos.FindAsync(id);
            if (estadoTurno != null)
            {
                _context.EstadoTurnos.Remove(estadoTurno);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoTurnoExists(int id)
        {
          return (_context.EstadoTurnos?.Any(e => e.EstadoTurnoId == id)).GetValueOrDefault();
        }
    }
}
