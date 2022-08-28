using bht_demo.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace bht_demo.Controllers
{
    public class ServiceController : Controller
    {
        private AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var service = _context.ServiceAndAbouts.Where(s => s.IsDeleted == false && s.Type == 0).ToList();
            return View(service);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();

            return View(_context.ServiceAndAbouts.Find(id));
        }
    }
}
