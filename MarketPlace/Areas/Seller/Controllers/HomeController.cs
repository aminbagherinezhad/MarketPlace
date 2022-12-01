using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Areas.Seller.Controllers
{
    public class HomeController : SellerBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
