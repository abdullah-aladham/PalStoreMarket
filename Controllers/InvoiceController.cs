using Microsoft.AspNetCore.Mvc;

namespace PalStoreMarket.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
