using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using learn.Data;
using learn.Models;

namespace learn.Controllers
{
    public class Class4Controller : Controller
    {
        private readonly learnContext _context;

        public Class4Controller(learnContext context)
        {
            _context = context;
        }

        // GET: Class4
        public async Task<IActionResult> Index(string searchString)
        {
            var Class4 = from m in _context.Class4
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                Class4 = Class4.Where(s => s.Name!.Contains(searchString));
            }

            return View(await Class4.ToListAsync());
        }

        // GET: Class4/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Class4 == null)
            {
                return NotFound();
            }

            var class4 = await _context.Class4
                .FirstOrDefaultAsync(m => m.Id == id);
            if (class4 == null)
            {
                return NotFound();
            }

            return View(class4);
        }

        // GET: Class4/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Class4/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Phonenumber,Id,Address,DateTime,MailAddress")] Class4 class4)
        {
            if (ModelState.IsValid)
            {
                _context.Add(class4);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(class4);
        }

        // GET: Class4/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Class4 == null)
            {
                return NotFound();
            }

            var class4 = await _context.Class4.FindAsync(id);
            if (class4 == null)
            {
                return NotFound();
            }
            return View(class4);
        }

        // POST: Class4/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Phonenumber,Id,Address,DateTime,MailAddress")] Class4 class4)
        {
            if (id != class4.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(class4);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Class4Exists(class4.Id))
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
            return View(class4);
        }

        // GET: Class4/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Class4 == null)
            {
                return NotFound();
            }

            var class4 = await _context.Class4
                .FirstOrDefaultAsync(m => m.Id == id);
            if (class4 == null)
            {
                return NotFound();
            }

            return View(class4);
        }

        // POST: Class4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Class4 == null)
            {
                return Problem("Entity set 'learnContext.Class4'  is null.");
            }
            var class4 = await _context.Class4.FindAsync(id);
            if (class4 != null)
            {
                _context.Class4.Remove(class4);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Class4Exists(int id)
        {
          return _context.Class4.Any(e => e.Id == id);
        }
    }
}
