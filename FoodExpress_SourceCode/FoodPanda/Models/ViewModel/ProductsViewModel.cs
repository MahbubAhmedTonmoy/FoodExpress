using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models.ViewModel
{
    public class ProductsViewModel
    {
        public Products Products { get; set; }
        public IEnumerable<ProductTypes> productTypes { get; set; }
        public IEnumerable<SpecialTags> specialTags { get; set; }
    }
}
