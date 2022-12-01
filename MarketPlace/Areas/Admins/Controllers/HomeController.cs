using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Areas.Admins.Controllers
{
    public class HomeController : AdminBaseController
    {
        #region index

        public IActionResult Index()
        {

            return View();
        }

        #endregion
    }
}
