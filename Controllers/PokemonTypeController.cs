using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;

namespace TermProject.Controllers
{
    public class PokemonTypeController : Controller
    {
        private readonly PokemonContext _context;

        public PokemonTypeController(PokemonContext context)
        {
            _context = context;
        }

        // GET: PokemonType
        public async Task<IActionResult> Index()
        {
            return View(await _context.PokemonTypes.ToListAsync());
        }

        // GET: PokemonType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypeWeaknessViewModel model = new TypeWeaknessViewModel();

            var pokemonType = await _context.PokemonTypes.FirstOrDefaultAsync(m => m.PokemonTypeId == id);
            if (pokemonType == null)
            {
                return NotFound();
            }

            var weakness = await _context.TypeWeakness.Where(w => w.PokemonTypeId == id).Include(t => t.Weakness).ToListAsync();

            model.Weaknesses = weakness;
            model.PokemonType = pokemonType;

            return View(model);
        }

        // GET: PokemonType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PokemonType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PokemonTypeId,Name")] PokemonType pokemonType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokemonType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokemonType);
        }

        // GET: PokemonType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemonType = await _context.PokemonTypes.FindAsync(id);
            if (pokemonType == null)
            {
                return NotFound();
            }
            return View(pokemonType);
        }

        // POST: PokemonType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PokemonTypeId,Name")] PokemonType pokemonType)
        {
            if (id != pokemonType.PokemonTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokemonType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonTypeExists(pokemonType.PokemonTypeId))
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
            return View(pokemonType);
        }

        // GET: PokemonType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemonType = await _context.PokemonTypes
                .FirstOrDefaultAsync(m => m.PokemonTypeId == id);
            if (pokemonType == null)
            {
                return NotFound();
            }

            return View(pokemonType);
        }

        // POST: PokemonType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pokemonType = await _context.PokemonTypes.FindAsync(id);
            _context.PokemonTypes.Remove(pokemonType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonTypeExists(int id)
        {
            return _context.PokemonTypes.Any(e => e.PokemonTypeId == id);
        }
    }
}
