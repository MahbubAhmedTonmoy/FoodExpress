using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models.ViewModel
{
    public class AppointmentDetailsViewModel
    {
        public Appointments Appointments { get; set; }
        public List<ApplicationUser> SalesPerson { get; set; }// admin show drop down of sales man
        public List<Products> Products { set; get; }
    }
}
