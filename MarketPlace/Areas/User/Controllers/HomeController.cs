using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        #region constructor



        #endregion

        #region user dashboard

        [HttpGet("")]
        public async Task<IActionResult> Dashboard()
        {
            return View();
        }

        #endregion
    }
}
