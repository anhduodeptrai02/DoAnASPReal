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
    public class LoaiSPModelsController : Controller
    {
        private readonly DPcontext _context;

        public LoaiSPModelsController(DPcontext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiSPModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiSanPham.ToListAsync());
        }

        // GET: Admin/LoaiSPModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSPModels = await _context.LoaiSanPham
                .FirstOrDefaultAsync(m => m.id == id);
            if (loaiSPModels == null)
            {
                return NotFound();
            }

            return View(loaiSPModels);
        }

        // GET: Admin/LoaiSPModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiSPModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ten")] LoaiSPModels loaiSPModels)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiSPModels);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiSPModels);
        }

        // GET: Admin/LoaiSPModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSPModels = await _context.LoaiSanPham.FindAsync(id);
            if (loaiSPModels == null)
            {
                return NotFound();
            }
            return View(loaiSPModels);
        }

        // POST: Admin/LoaiSPModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ten")] LoaiSPModels loaiSPModels)
        {
            if (id != loaiSPModels.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiSPModels);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSPModelsExists(loaiSPModels.id))
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
            return View(loaiSPModels);
        }

        // GET: Admin/LoaiSPModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSPModels = await _context.LoaiSanPham
                .FirstOrDefaultAsync(m => m.id == id);
            if (loaiSPModels == null)
            {
                return NotFound();
            }

            return View(loaiSPModels);
        }

        // POST: Admin/LoaiSPModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiSPModels = await _context.LoaiSanPham.FindAsync(id);
            _context.LoaiSanPham.Remove(loaiSPModels);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiSPModelsExists(int id)
        {
            return _context.LoaiSanPham.Any(e => e.id == id);
        }
    }
}
