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
        public IActionResult Index()
        {
            return View(_db.Flats.ToList());
        }




        
    }
}
