using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LIAECommerce;

namespace LIAECommerce.Controllers
{
    public class OcCategoryDescriptionsController : Controller
    {
        private readonly LIAECommerceContext _context;

        public OcCategoryDescriptionsController(LIAECommerceContext context)
        {
            _context = context;
        }

        // GET: OcCategoryDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.OcCategoryDescriptions.ToListAsync());
        }

        // GET: OcCategoryDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocCategoryDescription = await _context.OcCategoryDescriptions
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (ocCategoryDescription == null)
            {
                return NotFound();
            }

            return View(ocCategoryDescription);
        }

        // GET: OcCategoryDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OcCategoryDescriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,LanguageId,Name,Description,MetaTitle,MetaDescription,MetaKeyword")] OcCategoryDescription ocCategoryDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ocCategoryDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ocCategoryDescription);
        }

        // GET: OcCategoryDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocCategoryDescription = await _context.OcCategoryDescriptions.FindAsync(id);
            if (ocCategoryDescription == null)
            {
                return NotFound();
            }
            return View(ocCategoryDescription);
        }

        // POST: OcCategoryDescriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,LanguageId,Name,Description,MetaTitle,MetaDescription,MetaKeyword")] OcCategoryDescription ocCategoryDescription)
        {
            if (id != ocCategoryDescription.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ocCategoryDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OcCategoryDescriptionExists(ocCategoryDescription.CategoryId))
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
            return View(ocCategoryDescription);
        }

        // GET: OcCategoryDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocCategoryDescription = await _context.OcCategoryDescriptions
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (ocCategoryDescription == null)
            {
                return NotFound();
            }

            return View(ocCategoryDescription);
        }

        // POST: OcCategoryDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ocCategoryDescription = await _context.OcCategoryDescriptions.FindAsync(id);
            _context.OcCategoryDescriptions.Remove(ocCategoryDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcCategoryDescriptionExists(int id)
        {
            return _context.OcCategoryDescriptions.Any(e => e.CategoryId == id);
        }
    }
}
