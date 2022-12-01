using MarketPlace.Application.Services.Interfaces;
using MarketPlace.PresentationExtensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarketPlace.Areas.User.ViewComponents
{
    public class UserAccountViewComponent : ViewComponent
    {
        private readonly IUserService _userService;

        public UserAccountViewComponent(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //ViewBag.hasUserAnyActiveSellerPanel = await _userService.GetProfileForEdit(User.GetUserId());
            ViewData["User"] = await _userService.GetProfileForEdit(User.GetUserId());
            //var userProfile = await _userService.GetProfileForEdit(User.GetUserId());
            return View("UserAccount");
        }
    }
}
