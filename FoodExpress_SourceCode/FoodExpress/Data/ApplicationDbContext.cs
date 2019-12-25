using System;
using System.Collections.Generic;
using System.Text;
using FurnitureHouse.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FurnitureHouse.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProductTypes> ProductTypes { get; set; }

        public DbSet<SpecialTags> SpecialTags { set; get; }

        public DbSet<Products> products { get; set; }

        public DbSet<Appointments> Appointments { get; set; }

        public DbSet<ProductsSelectedForAppointment> ProductsSelectedForAppointment { get;set;}

        public DbSet<ApplicationUser> ApplicationUsers { set; get; }
    }
}
