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
    public class RegistationsController : Controller
    {
        private readonly AppDbContext _context;

        public RegistationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Registations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registations.ToListAsync());
        }

        // GET: Registations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registation = await _context.Registations
                .FirstOrDefaultAsync(m => m.U_Id == id);
            if (registation == null)
            {
                return NotFound();
            }

            return View(registation);
        }

        // GET: Registations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("U_Id,Name,Email,Password,ConfirmPassword,Phone,Gender")] Registation registation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registation);
        }

        // GET: Registations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registation = await _context.Registations.FindAsync(id);
            if (registation == null)
            {
                return NotFound();
            }
            return View(registation);
        }

        // POST: Registations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("U_Id,Name,Email,Password,ConfirmPassword,Phone,Gender")] Registation registation)
        {
            if (id != registation.U_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistationExists(registation.U_Id))
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
            return View(registation);
        }

        // GET: Registations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registation = await _context.Registations
                .FirstOrDefaultAsync(m => m.U_Id == id);
            if (registation == null)
            {
                return NotFound();
            }

            return View(registation);
        }

        // POST: Registations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registation = await _context.Registations.FindAsync(id);
            _context.Registations.Remove(registation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistationExists(int id)
        {
            return _context.Registations.Any(e => e.U_Id == id);
        }
    }
}
