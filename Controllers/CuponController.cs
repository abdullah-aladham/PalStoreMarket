using Microsoft.AspNetCore.Mvc;

namespace PalStoreMarket.Controllers
{
    public class CuponController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
