
using Microsoft.AspNetCore.Mvc;
using toletwebapp.Contexts;
using toletwebapp.Models;

namespace toletwebapp.Controllers
{
    public class BuildingController : Controller
    {
        private readonly IdentityDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BuildingController(IdentityDbContext db, IWebHostEnvironment wb)
        {
            _db = db;
            _webHostEnvironment = wb;
        }
        public IActionResult Index()
        {
            return View(_db.Buildings.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Building product)
        {
            //ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);

            if (ModelState.IsValid)
            {
                

                if (product.ImageUpload != null)
                {
                    string uploadsDir = Path.Combine(_webHostEnvironment.WebRootPath, "media/products");
                    string imageName = Guid.NewGuid().ToString() + "_" + product.ImageUpload.FileName;

                    string filePath = Path.Combine(uploadsDir, imageName);

                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await product.ImageUpload.CopyToAsync(fs);
                    fs.Close();

                    product.Image = imageName;
                }

                _db.Buildings.Add(product);
                await _db.SaveChangesAsync();
                TempData["Success"] = "The product has been created!";
                return RedirectToAction("Index");
            }

            return View(product);
        }



        //EDIT

        public async Task<IActionResult> Edit(Guid id)
        {
            Building product = await _db.Buildings.FindAsync(id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Building product)
        {
            //ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);

            if (product.ImageUpload != null)
            {
                string uploadsDir = Path.Combine(_webHostEnvironment.WebRootPath, "media/products");
                string imageName = Guid.NewGuid().ToString() + "_" + product.ImageUpload.FileName;

                string filePath = Path.Combine(uploadsDir, imageName);

                FileStream fs = new FileStream(filePath, FileMode.Create);
                await product.ImageUpload.CopyToAsync(fs);
                fs.Close();

                product.Image = imageName;
            }

            _db.Update(product);
            await _db.SaveChangesAsync();

            TempData["Success"] = "The product has been edited!";

            return Redirect("/Building/Index");
        }



        public async Task<IActionResult> CreateFlat(Guid id)
        {
            Building product = await _db.Buildings.FindAsync(id);
            Flat flat = new Flat();
            flat.Building = product;
            return View(flat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFlat(Guid id, Flat product)
        {
            //ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);

            if (product.ImageUpload1 != null)
            {
                string uploadsDir = Path.Combine(_webHostEnvironment.WebRootPath, "media/products");
                string imageName = Guid.NewGuid().ToString() + "_" + product.ImageUpload1.FileName;

                string filePath = Path.Combine(uploadsDir, imageName);

                FileStream fs = new FileStream(filePath, FileMode.Create);
                await product.ImageUpload1.CopyToAsync(fs);
                fs.Close();

                product.Image1 = imageName;
            }

            _db.Flats.Add(product);
            await _db.SaveChangesAsync();

            TempData["Success"] = "The Flat has been updated!";

            return Redirect("/Building/Index");
        }








        //FLAT

    }
}
