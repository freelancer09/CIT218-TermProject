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
    public class PokemonController : Controller
    {
        private readonly PokemonContext _context;

        public PokemonController(PokemonContext context)
        {
            _context = context;
        }

        // GET: Pokemon
        [AllowAnonymous]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber, int filter = 0)
        {
            int pageSize = 10;

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NumSortParm"] = String.IsNullOrEmpty(sortOrder) ? "num_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";
            ViewData["HpSortParm"] = sortOrder == "hp" ? "hp_desc" : "hp";
            ViewData["AtkSortParm"] = sortOrder == "atk" ? "atk_desc" : "atk";
            ViewData["DefSortParm"] = sortOrder == "def" ? "def_desc" : "def";
            ViewData["SpAtkSortParm"] = sortOrder == "spatk" ? "spatk_desc" : "spatk";
            ViewData["SpDefSortParm"] = sortOrder == "spdef" ? "spdef_desc" : "spdef";
            ViewData["SpeedSortParm"] = sortOrder == "speed" ? "speed_desc" : "speed";
            ViewData["TypeSortParm"] = sortOrder == "type" ? "type_desc" : "type";

            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;

            ViewData["CurrentFilter"] = searchString;            

            ViewData["FilterList"] = new SelectList(_context.PokemonTypes, "PokemonTypeId", "Name", filter);

            var pokemon = from p in _context.Pokemons.Include(p => p.PokemonType1).Include(p => p.PokemonType2) select p;

            if (!String.IsNullOrEmpty(searchString))
                pokemon = pokemon.Where(p => p.Name.Contains(searchString));

            if (filter != 0)
            {
                pokemon = pokemon.Where(p => p.PokemonType1Id == filter || p.PokemonType2Id == filter);
                ViewData["CurrentFilterType"] = filter;
            }
                

            switch (sortOrder)
            {
                case "num_desc":
                    pokemon = pokemon.OrderByDescending(s => s.PokedexNumber);
                    break;
                case "name":
                    pokemon = pokemon.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    pokemon = pokemon.OrderByDescending(s => s.Name);
                    break;
                case "hp":
                    pokemon = pokemon.OrderBy(s => s.Hp);
                    break;
                case "hp_desc":
                    pokemon = pokemon.OrderByDescending(s => s.Hp);
                    break;
                case "atk":
                    pokemon = pokemon.OrderBy(s => s.Attack);
                    break;
                case "atk_desc":
                    pokemon = pokemon.OrderByDescending(s => s.Attack);
                    break;
                case "def":
                    pokemon = pokemon.OrderBy(s => s.Defense);
                    break;
                case "def_desc":
                    pokemon = pokemon.OrderByDescending(s => s.Defense);
                    break;
                case "spatk":
                    pokemon = pokemon.OrderBy(s => s.SpAttack);
                    break;
                case "spatk_desc":
                    pokemon = pokemon.OrderByDescending(s => s.SpAttack);
                    break;
                case "spdef":
                    pokemon = pokemon.OrderBy(s => s.SpDefense);
                    break;
                case "spdef_desc":
                    pokemon = pokemon.OrderByDescending(s => s.SpDefense);
                    break;
                case "speed":
                    pokemon = pokemon.OrderBy(s => s.Speed);
                    break;
                case "speed_desc":
                    pokemon = pokemon.OrderByDescending(s => s.Speed);
                    break;
                case "type":
                    pokemon = pokemon.OrderBy(s => s.PokemonType1.Name);
                    break;
                case "type_desc":
                    pokemon = pokemon.OrderByDescending(s => s.PokemonType1.Name);
                    break;
                default:
                    pokemon = pokemon.OrderBy(s => s.PokedexNumber);
                    break;
            }
            return View(await PaginatedList<Pokemon>.CreateAsync(pokemon.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Pokemon/Details/5
        [AllowAnonymous]
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
