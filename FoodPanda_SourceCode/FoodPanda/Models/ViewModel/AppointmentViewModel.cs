using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models.ViewModel
{
    public class AppointmentViewModel
    {
        public List<Appointments> Appointments { set; get; }
        public PagingInfo PagingInfo { get; set; }
    }
}
