using System.Collections.Generic;
using System.Threading.Tasks;
using MarketPlace.Application.Services.Interfaces;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.DTOs.Products;
using MarketPlace.DataLayer.Entities.Mazholar;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Controllers
{
    public class ProductController : SiteBaseController
    {
        #region constructor

        private readonly IProductService _productService;
        private readonly ISellerService _sellerService;
        private readonly MarketPlaceDbContext _context;

        public ProductController(IProductService productService, ISellerService sellerService, MarketPlaceDbContext context)
        {
            _productService = productService;
            _sellerService = sellerService;
            _context = context;
        }

        #endregion


        public IActionResult Index(int pageId = 1, string filter = ""
            , string getType = "all", string orderByType = "date",
            int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null)
        {
            ViewBag.selectedGroups = selectedGroups;
            ViewBag.Groups = _productService.GetAllGroup();
            //ViewBag.pageId = pageId;
            return View(_productService.GetCourse(pageId, filter, getType, orderByType, startPrice, endPrice, selectedGroups));
        }
        #region filter products

        [HttpGet("products")]
        [HttpGet("products/{Category}")]
        public async Task<IActionResult> FilterProducts(FilterProductDTO filter)
        {
            filter.TakeEntity = 9;
            filter.FilterProductState = FilterProductState.Accepted;
            filter = await _productService.FilterProducts(filter);
            ViewBag.ProductCategories = await _productService.GetAllActiveProductCategories();
            if (filter.PageId > filter.GetLastPage() && filter.GetLastPage() != 0) return NotFound();
            return View(filter);
        }

        #endregion

        #region show product detail

        [HttpGet("products/{productId}/{title}")]
        public async Task<IActionResult> ProductDetail(long productId, string title)
        {
            var product = await _productService.GetProductDetailById(productId);
            if (product == null) return NotFound();
            return View(product);
        }

        #endregion


        #region Blog

        #region Filter Blog
        [HttpGet("blogs")]
        [HttpGet("blogs/{Category}")]
        public IActionResult FilterBlogs(/*Blog filter*/)
        {
            //var list = _sellerService.FilterBlogs(30);
            ViewData["Blog"] =  _sellerService.FilterBlogs(12);
            return View();
        }
        #endregion

        
        #endregion
    }
}
