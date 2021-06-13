using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDIMVC.Models;

namespace WebDIMVC.Controllers
{
    public class FishingBoatsController : Controller
    {
        private readonly FishingContext _context;

        public FishingBoatsController(FishingContext context)
        {
            _context = context;
        }

        // GET: FishingBoats
        public async Task<IActionResult> Index()
        {
            return View(await _context.FishingBoats.ToListAsync());
        }

        // GET: FishingBoats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingBoat = await _context.FishingBoats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fishingBoat == null)
            {
                return NotFound();
            }

            return View(fishingBoat);
        }

        // GET: FishingBoats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FishingBoats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Length,BoatName,Colour")] FishingBoat fishingBoat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fishingBoat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fishingBoat);
        }

        // GET: FishingBoats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingBoat = await _context.FishingBoats.FindAsync(id);
            if (fishingBoat == null)
            {
                return NotFound();
            }
            return View(fishingBoat);
        }

        // POST: FishingBoats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Length,BoatName,Colour")] FishingBoat fishingBoat)
        {
            if (id != fishingBoat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fishingBoat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FishingBoatExists(fishingBoat.Id))
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
            return View(fishingBoat);
        }

        // GET: FishingBoats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingBoat = await _context.FishingBoats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fishingBoat == null)
            {
                return NotFound();
            }

            return View(fishingBoat);
        }

        // POST: FishingBoats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fishingBoat = await _context.FishingBoats.FindAsync(id);
            _context.FishingBoats.Remove(fishingBoat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FishingBoatExists(int id)
        {
            return _context.FishingBoats.Any(e => e.Id == id);
        }
    }
}
