using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Application.Services.Interfaces;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.DTOs.Common;
using MarketPlace.DataLayer.DTOs.Seller;
using MarketPlace.DataLayer.Repository;
using MarketPlace.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Areas.Admins.Controllers
{
    public class SellerController : AdminBaseController
    {
        #region constructor

        private readonly ISellerService _sellerService;
        private readonly IProductService _productService;
        private readonly MarketPlaceDbContext _contextService;
       


        public SellerController(ISellerService sellerService, MarketPlaceDbContext contextService, IProductService productService)
        {
            _sellerService = sellerService;
            _productService = productService;
            _contextService = contextService;
        }

        #endregion

        #region seller requests

        public async Task<IActionResult> SellerRequests(FilterSellerDTO filter)
        {
            return View(await _sellerService.FilterSellers(filter));
        }

        #endregion

        #region accept seller request

        public async Task<IActionResult> AcceptSellerRequest(long requestId)
        {
            var result = await _sellerService.AcceptSellerRequest(requestId);

            if (result)
            {
                return JsonResponseStatus.SendStatus(
                    JsonResponseStatusType.Success,
                    "درخواست مورد نظر با موفقیت تایید شد",
                    null);
            }

            return JsonResponseStatus.SendStatus(JsonResponseStatusType.Danger,
                "اطلاعاتی با این مشخصات یافت نشد", null);
        }

        #endregion

        #region reject seller request

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> RejectSellerRequest(RejectItemDTO reject)
        {
            if (ModelState.IsValid)
            {
                var result = await _sellerService.RejectSellerRequest(reject);

                if (result)
                {
                    return JsonResponseStatus.SendStatus(
                        JsonResponseStatusType.Success,
                        "درخواست مورد نظر با موفقیت رد شد",
                        reject);
                }
            }

            return JsonResponseStatus.SendStatus(JsonResponseStatusType.Danger,
                "اطلاعاتی با این مشخصات یافت نشد", null);
        }

        #endregion


        #region ListPaymentSeller

        public async Task<IActionResult> ListPaymentSeller()
        {

            var listWallet =await _contextService.SellerWallets.ToListAsync();
            //var AllOrderdetailss = _contextService.SellerWallets.AsQueryable()
            //    .Include(g => g.Seller)
            //    .Where(s=>s.SellerId==)
            ViewData["Seller"] =await _productService.GetAllSeller(50);
            return View(listWallet);
                
           }
        #endregion
        #region send money for seller

        public async Task<IActionResult> SendMoneyForSeller(long id)
        {
            var result = await _productService.SendMoneyForSeller(id);
            if (result)
            {
                return JsonResponseStatus.SendStatus(JsonResponseStatusType.Success, "با موفقیت رسید واریز ثبت شد .", null);
            }

            return JsonResponseStatus.SendStatus(JsonResponseStatusType.Danger, "محصول مورد نظر یافت نشد", null);
        }
        #endregion
    }
}
