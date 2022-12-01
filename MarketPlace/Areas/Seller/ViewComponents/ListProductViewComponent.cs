using MarketPlace.Application.Services.Interfaces;
using MarketPlace.DataLayer.DTOs.Products;
using MarketPlace.PresentationExtensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarketPlace.Areas.Seller.ViewComponents
{
    public class ListProductViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ISellerService _sellerService;
        public ListProductViewComponent(IProductService productService, ISellerService sellerService)
        {
            _productService = productService;
            _sellerService = sellerService;
        }

        public async Task<IViewComponentResult> InvokeAsync(FilterProductDTO filter)
        {
            var seller = await _sellerService.GetLastActiveSellerByUserId(User.GetUserId());
            filter.SellerId = seller.Id;
            filter.FilterProductState = FilterProductState.All;
            ViewData["Product"] = await _productService.FilterProducts(filter);
            return View("ListProduct");
        }
    }
}
