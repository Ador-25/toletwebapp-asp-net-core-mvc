using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using toletwebapp.Contexts;

namespace toletwebapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlatApiController : ControllerBase
    {
        private readonly Contexts.IdentityDbContext _db;
        public FlatApiController(Contexts.IdentityDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetFlats()
        {
            var flats = await _db.Flats.ToListAsync();
            foreach (var flat in flats)
            {
                flat.Image1 = "https://localhost:7174/media/products/" + flat.Image1;
                flat.Image2 = "https://localhost:7174/media/products/" + flat.Image2;
                flat.Image3 = "https://localhost:7174/media/products/" + flat.Image3;
                flat.Image4 = "https://localhost:7174/media/products/" + flat.Image4; 
                flat.Image5 = "https://localhost:7174/media/products/" + flat.Image5;
                //flat.Image2 = "https://localhost:7174/media/products/" + flat.Image2;
            }
            return Ok(flats);
        }
        [Route("Buildings")]
        [HttpGet]
        public async Task<IActionResult> GetBuildings()
        {
            var buildings = await _db.Buildings.ToListAsync();
            foreach (var building in buildings)
            {
                building.Image = "https://localhost:7174/media/products/" + building.Image;
            }
            return Ok(buildings);
        }
    }
}
