using System.Threading.Tasks;
using MarketPlace.Application.Services.Interfaces;
using MarketPlace.PresentationExtensions;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.ViewComponents
{
    #region site header

    public class SiteHeaderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;

        public SiteHeaderViewComponent(ISiteService siteService, IUserService userService, IProductService productService)
        {
            _siteService = siteService;
            _userService = userService;
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.siteSetting = await _siteService.GetDefaultSiteSetting();
            ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name);
            }

            ViewBag.ProductCategories = await _productService.GetAllActiveProductCategories();

            return View("SiteHeader");
        }
    }

    #endregion

    #region site footer

    public class SiteFooterViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public SiteFooterViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.siteSetting = await _siteService.GetDefaultSiteSetting();

            return View("SiteFooter");
        }
    }

    #endregion

    #region SideBarAdmin

    public class SideBarAdminViewComponent : ViewComponent
    {
        

        public async Task<IViewComponentResult> InvokeAsync()
        {
          

            return View("SideBarAdmin");
        }
    }

    #endregion

    #region home sliders

    public class HomeSliderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public HomeSliderViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetAllActiveSliders();
            return View("HomeSlider", sliders);
        }
    }

    #endregion



    #region user

    public class UserViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public UserViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var user = await _productService.GetAllTUser(70);
            return View("User", user);
        }
    }

    #endregion


    #region home Property

    public class HomePropertyViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public HomePropertyViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetAllProperty();
            return View("HomeProperty", sliders);
        }
    }

    #endregion

    #region Logo

    public class LogoViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public LogoViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetLogo();
            return View("Logo", sliders);
        }
    }

    #endregion

    #region Social

    public class SocialViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public SocialViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetSocial();
            return View("Social", sliders);
        }
    }

    #endregion

    #region Category

    public class CategorysViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public CategorysViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetCategory();
            return View("Categorys", sliders);
        }
    }

    #endregion

    #region Blog

    public class BlogViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public BlogViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetBlog();
            return View("Blog", sliders);
        }
    }
    public class BlogRecentViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public BlogRecentViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetBlog();
            return View("BlogRecent", sliders);
        }
    }

    #endregion 
    
    #region Licis

    public class LicesViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public LicesViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetLices();
            return View("Lices", sliders);
        }
    }

    #endregion 

    #region Contact

    public class ContactViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public ContactViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetContact();
            return View("Contact", sliders);
        }
    }

    #endregion

    #region user order

    public class UserOrderViewComponent : ViewComponent
    {
        private readonly IOrderService _orderService;

        public UserOrderViewComponent(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // var openOrder = await _orderService.GetUserLatestOpenOrder(User.GetUserId());
            var openOrder = await _orderService.GetUserOpenOrderDetail(User.GetUserId());
            return View("UserOrder", openOrder);
        }
    }

    #endregion
}
