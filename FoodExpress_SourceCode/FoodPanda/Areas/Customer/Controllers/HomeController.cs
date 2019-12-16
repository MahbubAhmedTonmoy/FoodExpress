using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FurnitureHouse.Models;
using FurnitureHouse.Data;
using Microsoft.EntityFrameworkCore;
using FurnitureHouse.Extensions;

namespace FurnitureHouse.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(string search)
        {
            var productList = await _db.products.Include(m => m.ProductTypes).Include(m => m.SpecialTags).ToListAsync();

            if (!String.IsNullOrEmpty(search))
            {
                //productList = productList.Where(s => s.ProductTypes.Name.Contains(search)).ToList();
                productList = (from p in productList
                               where p.ProductTypes.Name.ToLower().Contains(search.ToLower())
                               select p).ToList();
            }
           
                return View(productList);
    
        }
        

        public async Task<IActionResult>Details(int id)
        {
            var product = await _db.products.Include(m => m.ProductTypes).Include(m => m.SpecialTags).Where(m => m.Id == id).FirstOrDefaultAsync();

            return View(product);
        }


        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailsPost(int id)
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if (lstShoppingCart == null)
            {
                lstShoppingCart = new List<int>();
            }
            lstShoppingCart.Add(id);
            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);

            return RedirectToAction("Index", "Home", new { area = "Customer" });

        }

        public IActionResult Remove(int id)
        {
            List<int> listShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");

            if (listShoppingCart.Count>0)
            {
                if (listShoppingCart.Contains(id))
                {
                    listShoppingCart.Remove(id);
                }
            }
            HttpContext.Session.Set("ssShoppingCart", listShoppingCart);

            return RedirectToAction(nameof(Index));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
