using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class ProductsSelectedForAppointment
    {
        public int Id { get; set; }

        public int AppointmentId { set; get; }

        [ForeignKey("AppointmentId")]
        public virtual Appointments Appointments { get; set; }

        public int ProductId { set; get; }

        [ForeignKey("ProductId")]
        public virtual Products Products { set; get; }
    }
}
