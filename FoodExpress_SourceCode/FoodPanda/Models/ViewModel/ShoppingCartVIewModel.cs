using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models.ViewModel
{
    public class ShoppingCartVIewModel
    {
        public List<Products> Products { set; get; }
        public Appointments Appointments { set; get; } 
    }
}
