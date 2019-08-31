using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureHouse.Data;
using FurnitureHouse.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FurnitureHouse.Utility;

namespace FurnitureHouse.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class AdminUserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminUserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.ApplicationUsers.ToList());//retrieve all the application user and pass to view
        }

        public async Task<IActionResult> Edit(string id)
        {
            if(id==null || id.Trim().Length== 0)
            {
                return NotFound();
            }
            var user = await _db.ApplicationUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id,ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                ApplicationUser user = _db.ApplicationUsers.Where(m => m.Id == id).FirstOrDefault();
                user.Name = applicationUser.Name;
                user.PhoneNumber = applicationUser.PhoneNumber;

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(applicationUser);
        }


        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }
            var user = await _db.ApplicationUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(string id)
        {
            ApplicationUser user = _db.ApplicationUsers.Where(m => m.Id == id).FirstOrDefault();

            user.LockoutEnd = DateTime.Now.AddYears(5);

            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}