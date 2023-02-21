using Microsoft.AspNetCore.Mvc;
using toletwebapp.Contexts;
using toletwebapp.Models;

namespace toletwebapp.Controllers
{
    public class FlatController : Controller
    {
        private readonly IdentityDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FlatController(IdentityDbContext db, IWebHostEnvironment wb)
        {
            _db = db;
            _webHostEnvironment = wb;
        }
        public IActionResult Index(Guid id)
        {
            return View(_db.Flats.Where(u=>u.Id==id).ToList());
        }
        public IActionResult Details(int id) {
            var flat = _db.Flats.Find(id);
            var building = _db.Buildings.Find(flat.Id);
            flat.Building = building;
            return View(flat);
        }
    }
}
