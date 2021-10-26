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
    public class OcCustomersController : Controller
    {
        private readonly LIAECommerceContext _context;

        public OcCustomersController(LIAECommerceContext context)
        {
            _context = context;
        }

        // GET: OcCustomers
        public async Task<IActionResult> Index()
        {
            return View(await _context.OcCustomers.ToListAsync());
        }

        // GET: OcCustomers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocCustomer = await _context.OcCustomers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (ocCustomer == null)
            {
                return NotFound();
            }

            return View(ocCustomer);
        }

        // GET: OcCustomers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OcCustomers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerGroupId,StoreId,LanguageId,Firstname,Lastname,Email,Telephone,Fax,Password,Salt,Cart,Wishlist,Newsletter,AddressId,CustomField,Ip,Status,Safe,Token,Code,DateAdded")] OcCustomer ocCustomer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ocCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ocCustomer);
        }

        // GET: OcCustomers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocCustomer = await _context.OcCustomers.FindAsync(id);
            if (ocCustomer == null)
            {
                return NotFound();
            }
            return View(ocCustomer);
        }

        // POST: OcCustomers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustomerGroupId,StoreId,LanguageId,Firstname,Lastname,Email,Telephone,Fax,Password,Salt,Cart,Wishlist,Newsletter,AddressId,CustomField,Ip,Status,Safe,Token,Code,DateAdded")] OcCustomer ocCustomer)
        {
            if (id != ocCustomer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ocCustomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OcCustomerExists(ocCustomer.CustomerId))
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
            return View(ocCustomer);
        }

        // GET: OcCustomers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocCustomer = await _context.OcCustomers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (ocCustomer == null)
            {
                return NotFound();
            }

            return View(ocCustomer);
        }

        // POST: OcCustomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ocCustomer = await _context.OcCustomers.FindAsync(id);
            _context.OcCustomers.Remove(ocCustomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcCustomerExists(int id)
        {
            return _context.OcCustomers.Any(e => e.CustomerId == id);
        }
    }
}
