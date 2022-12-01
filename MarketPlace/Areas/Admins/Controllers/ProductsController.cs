using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Application.Services.Interfaces;
using MarketPlace.DataLayer.DTOs.Common;
using MarketPlace.DataLayer.DTOs.Products;
using MarketPlace.Http;
using MarketPlace.DataLayer.Context;
using MarketPlace.Application.Senders;

namespace MarketPlace.Areas.Admins.Controllers
{
    public class ProductsController : AdminBaseController
    {
        #region constructor

        private readonly IProductService _productService;
        private IViewRenderService _viewRender;
        private MarketPlaceDbContext _context;
        public ProductsController(IProductService productService, IViewRenderService viewRender)
        {
            _productService = productService;
            _viewRender = viewRender;
        }

        #endregion

        #region filter products

        public async Task<IActionResult> Index(FilterProductDTO filter)
        {
            return View(await _productService.FilterProducts(filter));
        }

        #endregion

        #region accept product

        public async Task<IActionResult> AcceptSellerProduct(long id)
        {
            var result = await _productService.AcceptSellerProduct(id);
            if (result)
            {
                return JsonResponseStatus.SendStatus(JsonResponseStatusType.Success, "محصول مورد نظر با موفقیت تایید شد", null);
            }

            return JsonResponseStatus.SendStatus(JsonResponseStatusType.Danger, "محصول مورد نظر یافت نشد", null);
        }

        #endregion

        #region reject product

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> RejectProduct(RejectItemDTO reject)
        {
            if (ModelState.IsValid)
            {
                var result = await _productService.RejectSellerProduct(reject);

                if (result)
                {
                    // await _productService.RejectSellerSendEmail(reject);
                    return JsonResponseStatus.SendStatus(JsonResponseStatusType.Success,

                        "محصول مورد نظر با موفقیت رد شد", reject);
                }

                return JsonResponseStatus.SendStatus(JsonResponseStatusType.Danger, "اطلاعات مورد نظر جهت عدم تایید را به درستی وارد نمایید", null);
            }


            return JsonResponseStatus.SendStatus(JsonResponseStatusType.Danger, "محصول مورد نظر یافت نشد", null);
        }

        #endregion
    }
}
