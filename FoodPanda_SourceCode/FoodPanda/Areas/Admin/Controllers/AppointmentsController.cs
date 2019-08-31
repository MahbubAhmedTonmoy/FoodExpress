using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using FurnitureHouse.Data;
using FurnitureHouse.Models;
using FurnitureHouse.Models.ViewModel;
using FurnitureHouse.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureHouse.Areas.Admin.Controllers
{
    [Authorize(Roles =SD.SalesMan + ","+SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private int PageSize = 3;

        public AppointmentsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int productPage = 1, string searchName = null, string searchEmail = null, string searchPhone = null, string searchDate = null)
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            AppointmentViewModel appointmentVM = new AppointmentViewModel()
            {
                Appointments = new List<Models.Appointments>()
            };

            StringBuilder param = new StringBuilder();

            param.Append("/Admin/Appointments?productPage=:");
            param.Append("&searchName");
            if (searchName != null)
            {
                param.Append(searchName);
            }
            param.Append("&searchEmail");
            if (searchEmail != null)
            {
                param.Append(searchEmail);
            }
            param.Append("&searchPhone");
            if (searchPhone != null)
            {
                param.Append(searchPhone);
            }
            param.Append("&searchDate");
            if (searchDate != null)
            {
                param.Append(searchDate);
            }




            appointmentVM.Appointments = _db.Appointments.Include(a => a.SalesPerson).ToList();
            if (User.IsInRole(SD.SalesMan))
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.SalesPersonId == claim.Value).ToList();
            }


            if (searchName != null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.CustomerName.ToLower().Contains(searchName.ToLower())).ToList();
            }
            if (searchEmail != null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.CustomerEmail.ToLower().Contains(searchEmail.ToLower())).ToList();
            }
            if (searchPhone != null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.CustomerPhoneNumber.ToLower().Contains(searchPhone.ToLower())).ToList();
            }
            if (searchDate != null)
            {
                try
                {
                    DateTime appDate = Convert.ToDateTime(searchDate);
                    appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.AppointmentDate.ToShortDateString().Equals(appDate.ToShortDateString())).ToList();
                }
                catch (Exception ex)
                {

                }

            }

            var count = appointmentVM.Appointments.Count;

            appointmentVM.Appointments = appointmentVM.Appointments.OrderBy(p => p.AppointmentDate)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize).ToList();


            appointmentVM.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = count,
                urlParam = param.ToString()
            };


            return View(appointmentVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //retrieve product for particular appointment so join product and productSelectedforAppointment

            var productList = (IEnumerable<Products>)(from p in _db.products
                                                      join a in _db.ProductsSelectedForAppointment
                                                      on p.Id equals a.ProductId
                                                      where a.AppointmentId == id
                                                      select p).Include("ProductTypes");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointments = _db.Appointments.Include(a => a.SalesPerson).Where(a => a.Id == id).FirstOrDefault(),
                SalesPerson = _db.ApplicationUsers.ToList(),
                Products = productList.ToList()
            };
            return View(objAppointmentVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,AppointmentDetailsViewModel objAppointmentVM)
        {
            if (ModelState.IsValid)
            {
                objAppointmentVM.Appointments.AppointmentDate = objAppointmentVM.Appointments.AppointmentDate
                                        .AddHours(objAppointmentVM.Appointments.AppointmentTime.Hour)
                                        .AddMinutes(objAppointmentVM.Appointments.AppointmentTime.Minute);

                var appointmentFormDb = _db.Appointments.Where(a => a.Id ==objAppointmentVM.Appointments.Id).FirstOrDefault();

                appointmentFormDb.CustomerName = objAppointmentVM.Appointments.CustomerName;
                appointmentFormDb.CustomerEmail = objAppointmentVM.Appointments.CustomerEmail;
                appointmentFormDb.CustomerPhoneNumber = objAppointmentVM.Appointments.CustomerPhoneNumber;
                appointmentFormDb.AppointmentDate = objAppointmentVM.Appointments.AppointmentDate;
                appointmentFormDb.isConfirmed = objAppointmentVM.Appointments.isConfirmed;

                if (User.IsInRole(SD.SuperAdminEndUser))
                {
                    appointmentFormDb.SalesPersonId = objAppointmentVM.Appointments.SalesPersonId;
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(objAppointmentVM);
        }



        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //retrieve product for particular appointment so join product and productSelectedforAppointment

            var productList = (IEnumerable<Products>)(from p in _db.products
                                                      join a in _db.ProductsSelectedForAppointment
                                                      on p.Id equals a.ProductId
                                                      where a.AppointmentId == id
                                                      select p).Include("ProductTypes");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointments = _db.Appointments.Include(a => a.SalesPerson).Where(a => a.Id == id).FirstOrDefault(),
                SalesPerson = _db.ApplicationUsers.ToList(),
                Products = productList.ToList()
            };
            return View(objAppointmentVM);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //retrieve product for particular appointment so join product and productSelectedforAppointment

            var productList = (IEnumerable<Products>)(from p in _db.products
                                                      join a in _db.ProductsSelectedForAppointment
                                                      on p.Id equals a.ProductId
                                                      where a.AppointmentId == id
                                                      select p).Include("ProductTypes");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointments = _db.Appointments.Include(a => a.SalesPerson).Where(a => a.Id == id).FirstOrDefault(),
                SalesPerson = _db.ApplicationUsers.ToList(),
                Products = productList.ToList()
            };
            return View(objAppointmentVM);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int id)
        {
            var appointment = await _db.Appointments.FindAsync(id);
            _db.Appointments.Remove(appointment);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}