
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
    }
}
