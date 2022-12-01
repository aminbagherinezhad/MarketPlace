using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Application.Services.Interfaces;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.DTOs.SellerWallet;
using MarketPlace.DataLayer.Entities.ProductOrder;
using MarketPlace.DataLayer.Entities.Store;
using MarketPlace.DataLayer.Repository;
using MarketPlace.Http;
using MarketPlace.PresentationExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Areas.Seller.Controllers
{
    public class SellerWalletController : SellerBaseController
    {
        #region constructor

        private readonly ISellerWalletService _sellerWalletService;
        private readonly ISellerService _sellerService;
        private readonly IProductService _productService;
        private readonly MarketPlaceDbContext _context;


        private readonly IGenericRepository<OrderDetail> _orderDetailRepository;

        public SellerWalletController(ISellerWalletService sellerWalletService, MarketPlaceDbContext context, IProductService productService, ISellerService sellerService, IGenericRepository<OrderDetail> orderDetailRepository)
        {
            _sellerWalletService = sellerWalletService;
            _productService = productService;
            _context = context;
            _sellerService = sellerService;
            _orderDetailRepository = orderDetailRepository;
        }

        #endregion

        #region index

        [HttpGet("seller-wallet")]
        public async Task<IActionResult> Index(FilterSellerWalletDTO filter)
        {
            filter.TakeEntity = 5;
            var seller = await _sellerService.GetLastActiveSellerByUserId(User.GetUserId());
            if (seller == null) return NotFound();
            filter.SellerId = seller.Id;

            return View(await _sellerWalletService.FilterSellerWallet(filter));
        }

        #endregion


        #region detailsorderforseller
        [HttpGet("detail")]
        public async Task<IActionResult> detail()
        {
            var seller = await _sellerService.GetLastActiveSellerByUserId(User.GetUserId());
           // var AllOrderdetails = _context.OrderDetails.Where(g => g.Order.IsPaid && g.Product.SellerId == seller.Id);
            var data = await _orderDetailRepository.GetQuery()
                .Include(s => s.Order)
                .ThenInclude(s => s.OrderDetails)
                .ThenInclude(s => s.Product)
                .ThenInclude(s => s.ProductColors) 
                .Where(s => s.Product.SellerId == seller.Id)//TODO:s.Order.IsPaid
                .Select(s => s.Order).ToListAsync();
            ViewData["User"] = await _productService.GetAllTUser(500);
            ViewData["Product"] = await _productService.GetAllProducts(500);
            ViewData["OrderDetails"] = await _productService.GetAllOrderDetails(500);
            //ViewData["Color"] = await _productService.GetAllProducts(500);
            return View(data.ToList());
        }

        #endregion
    }
}
