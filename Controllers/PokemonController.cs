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
    public class PokemonController : Controller
    {
        private readonly PokemonContext _context;

        public PokemonController(PokemonContext context)
        {
            _context = context;
        }

        // GET: Pokemon
        public async Task<IActionResult> Index()
        {
            var pokemonContext = _context.Pokemons.Include(p => p.PokemonType1).Include(p => p.PokemonType2);
            return View(await pokemonContext.ToListAsync());
        }

        // GET: Pokemon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons
                .Include(p => p.PokemonType1)
                .Include(p => p.PokemonType2)
                .FirstOrDefaultAsync(m => m.PokemonId == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // GET: Pokemon/Create
        public IActionResult Create()
        {
            ViewData["PokemonType1Id"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name");
            ViewData["PokemonType2Id"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name");
            return View();
        }

        // POST: Pokemon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PokemonId,Name,PokedexNumber,Hp,Attack,Defense,SpAttack,SpDefense,Speed,PokemonType1Id,PokemonType2Id")] Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokemon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PokemonType1Id"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", pokemon.PokemonType1Id);
            ViewData["PokemonType2Id"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", pokemon.PokemonType2Id);
            return View(pokemon);
        }

        // GET: Pokemon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            ViewData["PokemonType1Id"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", pokemon.PokemonType1Id);
            ViewData["PokemonType2Id"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", pokemon.PokemonType2Id);
            return View(pokemon);
        }

        // POST: Pokemon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PokemonId,Name,PokedexNumber,Hp,Attack,Defense,SpAttack,SpDefense,Speed,PokemonType1Id,PokemonType2Id")] Pokemon pokemon)
        {
            if (id != pokemon.PokemonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokemon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonExists(pokemon.PokemonId))
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
            ViewData["PokemonType1Id"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", pokemon.PokemonType1Id);
            ViewData["PokemonType2Id"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", pokemon.PokemonType2Id);
            return View(pokemon);
        }

        // GET: Pokemon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons
                .Include(p => p.PokemonType1)
                .Include(p => p.PokemonType2)
                .FirstOrDefaultAsync(m => m.PokemonId == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // POST: Pokemon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pokemon = await _context.Pokemons.FindAsync(id);
            _context.Pokemons.Remove(pokemon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonExists(int id)
        {
            return _context.Pokemons.Any(e => e.PokemonId == id);
        }
    }
}
