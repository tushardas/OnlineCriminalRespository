using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineCrimeRepo.Models;

namespace OnlineCrimeRepo.Controllers
{
    public class CriminalController : Controller
    {
        private readonly OrpContext _context;

        public CriminalController(OrpContext context)
        {
            _context = context;
        }

        // GET: Criminal
        public async Task<IActionResult> Index()
        {
            return View(await _context.Criminal.ToListAsync());
        }

        // GET: Criminal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criminal = await _context.Criminal
                .SingleOrDefaultAsync(m => m.ID == id);
            if (criminal == null)
            {
                return NotFound();
            }

            return View(criminal);
        }

        // GET: Criminal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Criminal/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,DateOfBirth,CrimeRate,Address,Gender,Height,Weight,Complexion,EyeColor")] Criminal criminal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(criminal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(criminal);
        }

        // GET: Criminal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criminal = await _context.Criminal.SingleOrDefaultAsync(m => m.ID == id);
            if (criminal == null)
            {
                return NotFound();
            }
            return View(criminal);
        }

        // POST: Criminal/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,DateOfBirth,CrimeRate,Address,Gender,Height,Weight,Complexion,EyeColor")] Criminal criminal)
        {
            if (id != criminal.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(criminal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CriminalExists(criminal.ID))
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
            return View(criminal);
        }

        // GET: Criminal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criminal = await _context.Criminal
                .SingleOrDefaultAsync(m => m.ID == id);
            if (criminal == null)
            {
                return NotFound();
            }

            return View(criminal);
        }

        // POST: Criminal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var criminal = await _context.Criminal.SingleOrDefaultAsync(m => m.ID == id);
            _context.Criminal.Remove(criminal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CriminalExists(int id)
        {
            return _context.Criminal.Any(e => e.ID == id);
        }
    }
}
