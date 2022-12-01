using System.Threading.Tasks;
using MarketPlace.Application.Services.Interfaces;
using MarketPlace.PresentationExtensions;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Areas.User.ViewComponents
{
    public class UserSidebarViewComponent : ViewComponent
    {
        private ISellerService _sellerService;

        public UserSidebarViewComponent(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.hasUserAnyActiveSellerPanel = await _sellerService.HasUserAnyActiveSellerPanel(User.GetUserId());

            return View("UserSidebar");
        }
    }
}
