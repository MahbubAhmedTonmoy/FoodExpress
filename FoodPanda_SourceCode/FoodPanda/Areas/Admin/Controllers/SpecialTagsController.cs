using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FurnitureHouse.Data;
using FurnitureHouse.Models;
using Microsoft.AspNetCore.Authorization;
using FurnitureHouse.Utility;

namespace FurnitureHouse.Areas.Admin.Controllers
{
    [Authorize(Roles =SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class SpecialTagsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SpecialTagsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.SpecialTags.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialTags st)
        {
            if (ModelState.IsValid)
            {
                _db.Add(st);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(st);
        }

        public async Task<IActionResult>Edit(int? id)
        {
            if(id== null)
            {
                return NotFound();
            }
            var st = await _db.SpecialTags.FindAsync(id);
            if(st == null){
                return NotFound();
            }

            return View(st);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,SpecialTags st)
        {
            if(id != st.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(st);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(st);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var st = await _db.SpecialTags.FindAsync(id);
            if (st == null)
            {
                return NotFound();
            }

            return View(st);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var st =await _db.SpecialTags.FindAsync(id);
            if (st == null)
            {
                return NotFound();
            }

            return View(st);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var st = await _db.SpecialTags.FindAsync(id);
            _db.SpecialTags.Remove(st);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}