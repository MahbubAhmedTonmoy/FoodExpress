using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FurnitureHouse.Data;
using FurnitureHouse.Extensions;
using FurnitureHouse.Models;
using FurnitureHouse.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureHouse.Areas.Customer.Controllers
{

    [Area("Customer")]
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public ShoppingCartVIewModel ShoppingCartVM { set; get; }

        public ShoppingCartController(ApplicationDbContext db)
        {
            _db = db;
            ShoppingCartVM = new ShoppingCartVIewModel()
            {
                Products = new List<Models.Products>()
            };
        }



        public async Task<IActionResult> Index()
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if (lstShoppingCart.Count > 0)
            {
                foreach (int cartItem in lstShoppingCart)
                {
                    Products prod = _db.products.Include(p => p.SpecialTags).Include(p => p.ProductTypes).Where(p => p.Id == cartItem).FirstOrDefault();
                    ShoppingCartVM.Products.Add(prod);
                }
            }
            return View(ShoppingCartVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public async Task<IActionResult> IndexPost()
        {
            List<int> listCartItems = HttpContext.Session.Get<List<int>>("ssShoppingCart");

            //marge appointment day and time 
            ShoppingCartVM.Appointments.AppointmentDate = ShoppingCartVM.Appointments.AppointmentDate
                                                        .AddHours(ShoppingCartVM.Appointments.AppointmentTime.Hour)
                                                        .AddMinutes(ShoppingCartVM.Appointments.AppointmentTime.Minute);

            //object of Appointment
            Appointments appointments = ShoppingCartVM.Appointments;
            _db.Appointments.Add(appointments);
            _db.SaveChanges();

            // now we get appointment id cz last step we crear an appointment
            int appointmentId = appointments.Id;

            // now use this id inside the product selected for an appointment
            foreach (int productId in listCartItems)
            {
                ProductsSelectedForAppointment psfa = new ProductsSelectedForAppointment()
                {
                    AppointmentId = appointmentId,
                    ProductId = productId

                };
                _db.ProductsSelectedForAppointment.Add(psfa);
            }
            _db.SaveChanges();
            listCartItems = new List<int>(); // after add empty list
            HttpContext.Session.Set("ssShoppingCart", listCartItems);

            return RedirectToAction("AppointmentConfirmation", "ShoppingCart", new { Id = appointmentId});

        }

        public IActionResult Remove(int id)
        {
            List<int> listCartItem = HttpContext.Session.Get<List<int>>("ssShoppingCart");

            if (listCartItem.Count > 0)
            {
                if (listCartItem.Contains(id))
                {
                    listCartItem.Remove(id);
                }
            }
            // afet remove set session
            HttpContext.Session.Set("ssShoppingCart", listCartItem);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AppointmentConfirmation(int id)// appointment id
        {
            //retrieve appointment 
            ShoppingCartVM.Appointments = _db.Appointments.Where(m => m.Id == id).FirstOrDefault();

            // retrieve product list under the appointment id
            List<ProductsSelectedForAppointment> objProductList = _db.ProductsSelectedForAppointment.Where(p => p.AppointmentId == id).ToList();

            foreach(ProductsSelectedForAppointment PSFA in objProductList)
            {
                ShoppingCartVM.Products.Add(_db.products.Include(p => p.ProductTypes).Include(p => p.SpecialTags).Where(p => p.Id == PSFA.ProductId).FirstOrDefault());
            }
            return View(ShoppingCartVM);
        }
    } 

}