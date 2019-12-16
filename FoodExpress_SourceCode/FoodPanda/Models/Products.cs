using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class Products
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool Available { get; set; }

        public string Spicyness { get; set; }
        public enum EScipy { NA = 0, Spicy = 1, VerySpicy = 2 }

        public string Description { get; set; }

        public string Image { get; set; }
        
        [Display(Name="Product Type")]
        public int ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]
        public virtual ProductTypes ProductTypes { get; set; }

        [Display(Name ="Special Tag")]
        public int SpecialTagsId { get; set; }

        [ForeignKey("SpecialTagsId")]
        public virtual SpecialTags SpecialTags { get; set; }

    }
}
