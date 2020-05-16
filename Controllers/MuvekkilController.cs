﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DntHukuk.Web.Data;
using DntHukuk.Web.Models;

namespace DntHukuk.Web.Controllers
{
    public class MuvekkilController : Controller
    {
        private readonly AuthDbContext _context;

        public MuvekkilController(AuthDbContext context)
        {
            _context = context;
        }

        // GET: Muvekkils
        public async Task<IActionResult> Listele()
        {
            return View(await _context.Muvekkil.ToListAsync());
        }

        // GET: Muvekkils/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muvekkil = await _context.Muvekkil
                .FirstOrDefaultAsync(m => m.muvekkilId == id);
            if (muvekkil == null)
            {
                return NotFound();
            }

            return View(muvekkil);
        }

        // GET: Muvekkils/Create
        public IActionResult Ekle()
        {
            return View();
        }

        // POST: Muvekkils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle([Bind("muvekkilId,muvekkilAdi,muvekkilSoyAdi,muvekkilTc,muvekkilTuruId,muvekkilSorumluAvukat,muvekkilEmaik,muvekkilTelefon,muvekkilAdres,muvekkilAciklama,muvekkilEvrakPath,muvekkilVergiDairesi,muvekkilVergiNo,muvekkilYetkiliIsim, muvekkilUyelikTarihi")] Muvekkil muvekkil)
        {
            if (ModelState.IsValid)
            {
                muvekkil.muvekkilId = Guid.NewGuid();
                muvekkil.muvekkilTuruId = Convert.ToInt32(HttpContext.Request.Form["muvekkilTurleriDropDown"]);
                _context.Add(muvekkil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(muvekkil);
        }

        // GET: Muvekkils/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muvekkil = await _context.Muvekkil.FindAsync(id);
            if (muvekkil == null)
            {
                return NotFound();
            }
            return View(muvekkil);
        }

        // POST: Muvekkils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("muvekkilId,muvekkilAdi,muvekkilSoyAdi,muvekkilTc,muvekkilTuruId,muvekkilSorumluAvukat,muvekkilEmaik,muvekkilTelefon,muvekkilAdres,muvekkilAciklama,muvekkilEvrakPath,muvekkilVergiDairesi,muvekkilVergiNo,muvekkilYetkiliIsim")] Muvekkil muvekkil)
        {
            if (id != muvekkil.muvekkilId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(muvekkil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MuvekkilExists(muvekkil.muvekkilId))
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
            return View(muvekkil);
        }

        // GET: Muvekkils/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muvekkil = await _context.Muvekkil
                .FirstOrDefaultAsync(m => m.muvekkilId == id);
            if (muvekkil == null)
            {
                return NotFound();
            }

            return View(muvekkil);
        }

        // POST: Muvekkils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var muvekkil = await _context.Muvekkil.FindAsync(id);
            _context.Muvekkil.Remove(muvekkil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MuvekkilExists(Guid id)
        {
            return _context.Muvekkil.Any(e => e.muvekkilId == id);
        }
    }
}
