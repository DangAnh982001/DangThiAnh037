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
    public class DTA0037Controller : Controller
    {
        private readonly ApplicationDbcontext _context;

        public DTA0037Controller(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: DTA0037
        public async Task<IActionResult> Index()
        {
              return _context.DTA0037 != null ? 
                          View(await _context.DTA0037.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbcontext.DTA0037'  is null.");
        }

        // GET: DTA0037/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.DTA0037 == null)
            {
                return NotFound();
            }

            var dTA0037 = await _context.DTA0037
                .FirstOrDefaultAsync(m => m.DTAId == id);
            if (dTA0037 == null)
            {
                return NotFound();
            }

            return View(dTA0037);
        }

        // GET: DTA0037/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DTA0037/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DTAId,DTAName,DTAGender")] DTA0037 dTA0037)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dTA0037);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dTA0037);
        }

        // GET: DTA0037/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.DTA0037 == null)
            {
                return NotFound();
            }

            var dTA0037 = await _context.DTA0037.FindAsync(id);
            if (dTA0037 == null)
            {
                return NotFound();
            }
            return View(dTA0037);
        }

        // POST: DTA0037/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DTAId,DTAName,DTAGender")] DTA0037 dTA0037)
        {
            if (id != dTA0037.DTAId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dTA0037);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTA0037Exists(dTA0037.DTAId))
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
            return View(dTA0037);
        }

        // GET: DTA0037/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.DTA0037 == null)
            {
                return NotFound();
            }

            var dTA0037 = await _context.DTA0037
                .FirstOrDefaultAsync(m => m.DTAId == id);
            if (dTA0037 == null)
            {
                return NotFound();
            }

            return View(dTA0037);
        }

        // POST: DTA0037/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.DTA0037 == null)
            {
                return Problem("Entity set 'ApplicationDbcontext.DTA0037'  is null.");
            }
            var dTA0037 = await _context.DTA0037.FindAsync(id);
            if (dTA0037 != null)
            {
                _context.DTA0037.Remove(dTA0037);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DTA0037Exists(string id)
        {
          return (_context.DTA0037?.Any(e => e.DTAId == id)).GetValueOrDefault();
        }
    }
}
