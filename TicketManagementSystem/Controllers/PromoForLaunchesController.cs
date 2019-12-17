using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketManagementSystem.Models;

namespace TicketManagementSystem.Controllers
{
    public class PromoForLaunchesController : Controller
    {
        private readonly AppDbContext _context;

        public PromoForLaunchesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PromoForLaunches
        public async Task<IActionResult> Index()
        {
            return View(await _context.PromoForLaunches.ToListAsync());
        }

        // GET: PromoForLaunches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoForLaunch = await _context.PromoForLaunches
                .FirstOrDefaultAsync(m => m.PFL_Id == id);
            if (promoForLaunch == null)
            {
                return NotFound();
            }

            return View(promoForLaunch);
        }

        // GET: PromoForLaunches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PromoForLaunches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PFL_Id")] PromoForLaunch promoForLaunch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(promoForLaunch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(promoForLaunch);
        }

        // GET: PromoForLaunches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoForLaunch = await _context.PromoForLaunches.FindAsync(id);
            if (promoForLaunch == null)
            {
                return NotFound();
            }
            return View(promoForLaunch);
        }

        // POST: PromoForLaunches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PFL_Id")] PromoForLaunch promoForLaunch)
        {
            if (id != promoForLaunch.PFL_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(promoForLaunch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PromoForLaunchExists(promoForLaunch.PFL_Id))
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
            return View(promoForLaunch);
        }

        // GET: PromoForLaunches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoForLaunch = await _context.PromoForLaunches
                .FirstOrDefaultAsync(m => m.PFL_Id == id);
            if (promoForLaunch == null)
            {
                return NotFound();
            }

            return View(promoForLaunch);
        }

        // POST: PromoForLaunches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var promoForLaunch = await _context.PromoForLaunches.FindAsync(id);
            _context.PromoForLaunches.Remove(promoForLaunch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PromoForLaunchExists(int id)
        {
            return _context.PromoForLaunches.Any(e => e.PFL_Id == id);
        }
    }
}
