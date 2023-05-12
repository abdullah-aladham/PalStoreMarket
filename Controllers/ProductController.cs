using Microsoft.AspNetCore.Mvc;

namespace PalStoreMarket.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
