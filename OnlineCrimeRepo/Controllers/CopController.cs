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
    public class CopController : Controller
    {
        private readonly OrpContext _context;

        public CopController(OrpContext context)
        {
            _context = context;
        }

        // GET: Cop
        public async Task<IActionResult> Index(string copDesignation, string copStation,string nameSearch)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> designationQuery = from c in _context.Cop
                                            orderby c.Designation
                                            select c.Designation;

            IQueryable<string> stationQuery = from c in _context.Cop
                                            orderby c.PoliceStation
                                            select c.PoliceStation;
            var cops = from c in _context.Cop
                         select c;

            if (!String.IsNullOrEmpty(nameSearch))
            {
                cops = cops.Where(s => s.Name.Contains(nameSearch));
            }

            if (!String.IsNullOrEmpty(copDesignation))
            {
                cops = cops.Where(x => x.Designation == copDesignation);
            }

            if (!String.IsNullOrEmpty(copStation))
            {
                cops = cops.Where(x => x.PoliceStation == copStation);
            }

            var copDesignationVM = new CopDesignationViewModel();
            copDesignationVM.designations = new SelectList(await designationQuery.Distinct().ToListAsync());
            copDesignationVM.stations = new SelectList(await stationQuery.Distinct().ToListAsync());
            copDesignationVM.cops = await cops.ToListAsync();

            return View(copDesignationVM);
        }

        // GET: Cop/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cop = await _context.Cop
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cop == null)
            {
                return NotFound();
            }

            return View(cop);
        }

        // GET: Cop/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cop/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CopID,Name,Designation,PoliceStation,DateOfBirth,PhoneNumber,Address")] Cop cop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cop);
        }

        // GET: Cop/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cop = await _context.Cop.SingleOrDefaultAsync(m => m.ID == id);
            if (cop == null)
            {
                return NotFound();
            }
            return View(cop);
        }

        // POST: Cop/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CopID,Name,Designation,PoliceStation,DateOfBirth,PhoneNumber,Address")] Cop cop)
        {
            if (id != cop.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CopExists(cop.ID))
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
            return View(cop);
        }

        // GET: Cop/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cop = await _context.Cop
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cop == null)
            {
                return NotFound();
            }

            return View(cop);
        }

        // POST: Cop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cop = await _context.Cop.SingleOrDefaultAsync(m => m.ID == id);
            _context.Cop.Remove(cop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CopExists(int id)
        {
            return _context.Cop.Any(e => e.ID == id);
        }
    }
}
