using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name="Sales Person")]
        public string Name { get; set; }

        [NotMapped]
        public bool Admin { set; get; }

        [NotMapped]
        public bool Sales { set; get; }
    }
}
