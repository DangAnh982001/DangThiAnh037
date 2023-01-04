using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DangThiAnh037.Models;

namespace DangThiAnh037.Controllers
{
    public class CompanyDTA037Controller : Controller
    {
        private readonly ApplicationDbcontext _context;

        public CompanyDTA037Controller(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: CompanyDTA037
        public async Task<IActionResult> Index()
        {
              return _context.CompanyDTA037 != null ? 
                          View(await _context.CompanyDTA037.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbcontext.CompanyDTA037'  is null.");
        }

        // GET: CompanyDTA037/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyDTA037 == null)
            {
                return NotFound();
            }

            var companyDTA037 = await _context.CompanyDTA037
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyDTA037 == null)
            {
                return NotFound();
            }

            return View(companyDTA037);
        }

        // GET: CompanyDTA037/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyDTA037/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyDTA037 companyDTA037)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyDTA037);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyDTA037);
        }

        // GET: CompanyDTA037/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyDTA037 == null)
            {
                return NotFound();
            }

            var companyDTA037 = await _context.CompanyDTA037.FindAsync(id);
            if (companyDTA037 == null)
            {
                return NotFound();
            }
            return View(companyDTA037);
        }

        // POST: CompanyDTA037/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyDTA037 companyDTA037)
        {
            if (id != companyDTA037.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyDTA037);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyDTA037Exists(companyDTA037.CompanyId))
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
            return View(companyDTA037);
        }

        // GET: CompanyDTA037/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyDTA037 == null)
            {
                return NotFound();
            }

            var companyDTA037 = await _context.CompanyDTA037
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyDTA037 == null)
            {
                return NotFound();
            }

            return View(companyDTA037);
        }

        // POST: CompanyDTA037/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyDTA037 == null)
            {
                return Problem("Entity set 'ApplicationDbcontext.CompanyDTA037'  is null.");
            }
            var companyDTA037 = await _context.CompanyDTA037.FindAsync(id);
            if (companyDTA037 != null)
            {
                _context.CompanyDTA037.Remove(companyDTA037);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyDTA037Exists(string id)
        {
          return (_context.CompanyDTA037?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}
