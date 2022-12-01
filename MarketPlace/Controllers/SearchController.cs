using MarketPlace.Application.Services.Interfaces;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Products;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MarketPlace.Controllers
{
    public class SearchController : Controller
    {
        #region constructor

        private readonly IProductService _productService;
        private readonly MarketPlaceDbContext _context;

        public SearchController(IProductService productService, MarketPlaceDbContext context)
        {
            _productService = productService;
            _context = context;
        }

        #endregion
        public ActionResult Index(string filter)
        {
            List<Product> list = new List<Product>();
         
            // list.AddRange(db.Product_Tags.Where(t => t.Tag == q).Select(t => t.Products).ToList());
            list.AddRange(_context.Products.Where(p => p.Title.Contains(filter) || p.ShortDescription.Contains(filter) || p.Description.Contains(filter)).ToList());

            ViewBag.search = filter;
            return View(list.Distinct());
        }
    }
}
