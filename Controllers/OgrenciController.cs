using Microsoft.AspNetCore.Mvc;

namespace entityFrameworkCoreApp.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
