using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnASP1.Areas.Admin.Data;
using DoAnASP1.Areas.Admin.Models;

namespace DoAnASP1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CTHoaDonsController : Controller
    {
        private readonly DPcontext _context;

        public CTHoaDonsController(DPcontext context)
        {
            _context = context;
        }

        // GET: Admin/CTHoaDons
        public async Task<IActionResult> Index()
        {
            return View(await _context.CTHoaDon.ToListAsync());
        }

        // GET: Admin/CTHoaDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTHoaDon = await _context.CTHoaDon
                .FirstOrDefaultAsync(m => m.MaCTHD == id);
            if (cTHoaDon == null)
            {
                return NotFound();
            }

            return View(cTHoaDon);
        }

        // GET: Admin/CTHoaDons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/CTHoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaCTHD,MaSP,SoLuong,ThanhTien")] CTHoaDon cTHoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cTHoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cTHoaDon);
        }

        // GET: Admin/CTHoaDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTHoaDon = await _context.CTHoaDon.FindAsync(id);
            if (cTHoaDon == null)
            {
                return NotFound();
            }
            return View(cTHoaDon);
        }

        // POST: Admin/CTHoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaCTHD,MaSP,SoLuong,ThanhTien")] CTHoaDon cTHoaDon)
        {
            if (id != cTHoaDon.MaCTHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cTHoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CTHoaDonExists(cTHoaDon.MaCTHD))
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
            return View(cTHoaDon);
        }

        // GET: Admin/CTHoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTHoaDon = await _context.CTHoaDon
                .FirstOrDefaultAsync(m => m.MaCTHD == id);
            if (cTHoaDon == null)
            {
                return NotFound();
            }

            return View(cTHoaDon);
        }

        // POST: Admin/CTHoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cTHoaDon = await _context.CTHoaDon.FindAsync(id);
            _context.CTHoaDon.Remove(cTHoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CTHoaDonExists(int id)
        {
            return _context.CTHoaDon.Any(e => e.MaCTHD == id);
        }
    }
}
