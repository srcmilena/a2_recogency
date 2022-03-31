using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using site.Models;

namespace site.Controllers
{
    public class PessoasController : Controller
    {
        private readonly Context _context;

        public PessoasController(Context context)
        {
            _context = context;
        }

        // GET: Pessoas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pessoas.ToListAsync());
        }

        // GET: Pessoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoas = await _context.Pessoas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pessoas == null)
            {
                return NotFound();
            }

            return View(pessoas);
        }

        // GET: Pessoas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,Origem,Destino,Saída,Retorno,Preço")] Pessoas pessoas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoas);
        }

        // GET: Pessoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoas = await _context.Pessoas.FindAsync(id);
            if (pessoas == null)
            {
                return NotFound();
            }
            return View(pessoas);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Origem,Destino,Saída,Retorno,Preço")] Pessoas pessoas)
        {
            if (id != pessoas.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoasExists(pessoas.ID))
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
            return View(pessoas);
        }

        // GET: Pessoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoas = await _context.Pessoas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pessoas == null)
            {
                return NotFound();
            }

            return View(pessoas);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pessoas = await _context.Pessoas.FindAsync(id);
            _context.Pessoas.Remove(pessoas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoasExists(int id)
        {
            return _context.Pessoas.Any(e => e.ID == id);
        }
    }
}
