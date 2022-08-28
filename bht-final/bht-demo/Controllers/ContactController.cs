using Microsoft.AspNetCore.Mvc;

namespace bht_demo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
