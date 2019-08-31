using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FurnitureHouse.Data;
using FurnitureHouse.Models;
using FurnitureHouse.Models.ViewModel;
using FurnitureHouse.Utility;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;



namespace FurnitureHouse.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class ProductsController : Controller
    {

        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;

        [BindProperty]
        public ProductsViewModel ProductsVM { get; set; }//property of view model

        public ProductsController(ApplicationDbContext db,HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            ProductsVM = new ProductsViewModel() {
                productTypes = _db.ProductTypes.ToList(),
                specialTags = _db.SpecialTags.ToList(),
                Products = new Models.Products()
            };
        }


        // in don't need view model because we find type name and tag name from products model 
        public async Task<IActionResult>Index()
        {
            var products = _db.products.Include(m => m.ProductTypes).Include(m => m.SpecialTags);
            return View(await products.ToListAsync());
        }

        public IActionResult Create()
        {
            return View(ProductsVM); // use view modle cz use drop down of product type and tags
        }

        [HttpPost,ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(ProductsVM);
            }

            _db.products.Add(ProductsVM.Products);
            await _db.SaveChangesAsync();

            //image save need hosting environment

            string webRootPath = _hostingEnvironment.WebRootPath;//retrieve the path of wwwroot folder

            //want to save image wwwroot->image and rename ta image using product id

            var files = HttpContext.Request.Form.Files; // retrievr uploaded files from view

            var productsFromDb = _db.products.Find(ProductsVM.Products.Id);

            if (files.Count != 0)
            {
                //image has been up
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);//find ta path 

                var extension = Path.GetExtension(files[0].FileName);// find extension


                //use filestream Object to copy file from uploaded to the server
                using (var filestream = new FileStream(Path.Combine(uploads,ProductsVM.Products.Id+extension),FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }

                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.Products.Id + extension;
            }

            else
            {
                //does not up image
                var updoads = Path.Combine(webRootPath, SD.ImageFolder+@"\"+SD.DefaultProductImage);
                System.IO.File.Copy(updoads, webRootPath + @"\" + SD.ImageFolder + @"\" + ProductsVM.Products.Id + ".jpg");
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.Products.Id +".jpg";
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            ProductsVM.Products = await _db.products.Include(m => m.ProductTypes).Include(m => m.SpecialTags).SingleOrDefaultAsync(m => m.Id == id);

            if (ProductsVM.Products == null)
            {
                return NotFound();
            }
            return View(ProductsVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (ModelState.IsValid)
            {
                string webRoothPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                //if update image at 1st delete curret image -> find out product from database
                var productFromDb = _db.products.Where(m => m.Id == ProductsVM.Products.Id).FirstOrDefault();

                if(files.Count>0 && files[0] != null)
                {
                    var uploads = Path.Combine(webRoothPath, SD.ImageFolder);

                    var extension_new = Path.GetExtension(files[0].FileName);

                    var extension_old = Path.GetExtension(productFromDb.Image);

                    //delete old image
                    if (System.IO.File.Exists(Path.Combine(uploads, ProductsVM.Products.Id + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads,ProductsVM.Products.Id+extension_old));
                    }

                    using (var filestream = new FileStream(Path.Combine(uploads, ProductsVM.Products.Id + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    ProductsVM.Products.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.Products.Id + extension_new;
                }
                if(ProductsVM.Products.Image != null)
                {
                    productFromDb.Image = ProductsVM.Products.Image;
                }

                productFromDb.Name = ProductsVM.Products.Name;
                productFromDb.Description = ProductsVM.Products.Description;
                productFromDb.Spicyness = ProductsVM.Products.Spicyness;
                productFromDb.Price = ProductsVM.Products.Price;
                productFromDb.Available = ProductsVM.Products.Available;
                productFromDb.ProductTypeId = ProductsVM.Products.ProductTypeId;
                productFromDb.SpecialTagsId = ProductsVM.Products.SpecialTagsId;
               

                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(ProductsVM);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            ProductsVM.Products = await _db.products.Include(m => m.ProductTypes).Include(m => m.SpecialTags).SingleOrDefaultAsync(m=>m.Id == id);

            if(ProductsVM.Products == null)
            {
                return NotFound();
            }
            return View(ProductsVM);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductsVM.Products = await _db.products.Include(m => m.ProductTypes).Include(m => m.SpecialTags).SingleOrDefaultAsync(m => m.Id == id);

            if (ProductsVM.Products == null)
            {
                return NotFound();
            }
            return View(ProductsVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            Products products = await _db.products.FindAsync(id); // another way to find -> where / firstordefault

            if(products == null)
            {
                return NotFound();
            }
            else
            {
                var upload = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(products.Image);

                if (System.IO.File.Exists(Path.Combine(upload, products.Id + extension)))
                {
                    System.IO.File.Delete(Path.Combine(upload, products.Id + extension));
                }
                _db.products.Remove(products);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
        }
    }
}