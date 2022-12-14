using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace TermProject.Controllers
{
    [Authorize]
    public class TypeWeaknessController : Controller
    {
        private readonly PokemonContext _context;

        public TypeWeaknessController(PokemonContext context)
        {
            _context = context;
        }

        // GET: TypeWeakness
        [AllowAnonymous]
        public IActionResult Index(string sortOrder)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["WeakSortParm"] = sortOrder == "weak" ? "weak_desc" : "weak";

            var weak = from w in _context.TypeWeakness.Include(t => t.PokemonType).Include(t => t.Weakness) select w;

            switch (sortOrder)
            {
                case "name_desc":
                    weak = weak.OrderByDescending(w => w.PokemonType.Name);
                    break;
                case "weak":
                    weak = weak.OrderBy(w => w.Weakness.Name);
                    break;
                case "weak_desc":
                    weak = weak.OrderByDescending(w => w.Weakness.Name);
                    break;
                default:
                    weak = weak.OrderBy(w => w.PokemonType.Name);
                    break;
            }
            return View(weak);
        }

        // GET: TypeWeakness/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeWeakness = await _context.TypeWeakness
                .Include(t => t.PokemonType)
                .Include(t => t.Weakness)
                .FirstOrDefaultAsync(m => m.TypeWeaknessId == id);
            if (typeWeakness == null)
            {
                return NotFound();
            }

            return View(typeWeakness);
        }

        // GET: TypeWeakness/Create
        public IActionResult Create()
        {
            ViewData["PokemonTypeId"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name");
            ViewData["WeaknessId"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name");
            return View();
        }

        // POST: TypeWeakness/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TypeWeaknessId,PokemonTypeId,WeaknessId")] TypeWeakness typeWeakness)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeWeakness);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PokemonTypeId"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", typeWeakness.PokemonTypeId);
            ViewData["WeaknessId"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", typeWeakness.WeaknessId);
            return View(typeWeakness);
        }

        // GET: TypeWeakness/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeWeakness = await _context.TypeWeakness.FindAsync(id);
            if (typeWeakness == null)
            {
                return NotFound();
            }
            ViewData["PokemonTypeId"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", typeWeakness.PokemonTypeId);
            ViewData["WeaknessId"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", typeWeakness.WeaknessId);
            return View(typeWeakness);
        }

        // POST: TypeWeakness/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TypeWeaknessId,PokemonTypeId,WeaknessId")] TypeWeakness typeWeakness)
        {
            if (id != typeWeakness.TypeWeaknessId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeWeakness);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeWeaknessExists(typeWeakness.TypeWeaknessId))
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
            ViewData["PokemonTypeId"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", typeWeakness.PokemonTypeId);
            ViewData["WeaknessId"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", typeWeakness.WeaknessId);
            return View(typeWeakness);
        }

        // GET: TypeWeakness/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeWeakness = await _context.TypeWeakness
                .Include(t => t.PokemonType)
                .Include(t => t.Weakness)
                .FirstOrDefaultAsync(m => m.TypeWeaknessId == id);
            if (typeWeakness == null)
            {
                return NotFound();
            }

            return View(typeWeakness);
        }

        // POST: TypeWeakness/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeWeakness = await _context.TypeWeakness.FindAsync(id);
            _context.TypeWeakness.Remove(typeWeakness);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeWeaknessExists(int id)
        {
            return _context.TypeWeakness.Any(e => e.TypeWeaknessId == id);
        }
    }
}
