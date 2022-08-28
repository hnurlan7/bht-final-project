using Microsoft.AspNetCore.Mvc;

namespace bht_demo.Areas.AdminPanel.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
