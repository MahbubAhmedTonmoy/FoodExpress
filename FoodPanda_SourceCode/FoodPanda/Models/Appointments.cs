using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class Appointments
    {
        public int Id { get; set; }

        [Display(Name = "Sales Person")]
        public string SalesPersonId { set; get; }

        [ForeignKey("SalesPersonId")]
        public virtual ApplicationUser SalesPerson { get; set; }





        public DateTime AppointmentDate { set; get; }

        [NotMapped]
        public DateTime AppointmentTime { set; get; }

        public string CustomerName { set; get; }

        public string CustomerPhoneNumber { set; get; }

        public string CustomerEmail { set; get; }

        public bool isConfirmed { set; get; }

    }
}
