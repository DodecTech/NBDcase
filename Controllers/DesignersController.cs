﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NBDcase.Data;
using NBDcase.Models;
using NBDcase.Utilities;

namespace NBDcase.Controllers
{
    public class DesignersController : Controller
    {
        private readonly NBDContext _context;

        public DesignersController(NBDContext context)
        {
            _context = context;
        }

        // GET: Designers
        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 3;//Change as required
            var PageData = await PaginatedList<Designer>.CreateAsync(_context.Designers.AsNoTracking(), page ?? 1, pageSize);

            return View(PageData);
        }

        // GET: Designers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designer = await _context.Designers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (designer == null)
            {
                return NotFound();
            }

            return View(designer);
        }

        // GET: Designers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Designers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,eMail,Phone")] Designer designer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(designer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(designer);
        }

        // GET: Designers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designer = await _context.Designers.FindAsync(id);
            if (designer == null)
            {
                return NotFound();
            }
            return View(designer);
        }

        // POST: Designers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,eMail,Phone")] Designer designer)
        {
            if (id != designer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(designer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesignerExists(designer.ID))
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
            return View(designer);
        }

        // GET: Designers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designer = await _context.Designers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (designer == null)
            {
                return NotFound();
            }

            return View(designer);
        }

        // POST: Designers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var designer = await _context.Designers.FindAsync(id);
            _context.Designers.Remove(designer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesignerExists(int id)
        {
            return _context.Designers.Any(e => e.ID == id);
        }
    }
}
