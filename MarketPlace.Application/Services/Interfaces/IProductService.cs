using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MarketPlace.DataLayer.DTOs;
using MarketPlace.DataLayer.DTOs.Common;
using MarketPlace.DataLayer.DTOs.Products;
using MarketPlace.DataLayer.Entities.Abouts;
using MarketPlace.DataLayer.Entities.Account;
using MarketPlace.DataLayer.Entities.Mazholar;
using MarketPlace.DataLayer.Entities.ProductOrder;
using MarketPlace.DataLayer.Entities.Products;
using MarketPlace.DataLayer.Entities.Store;
using MarketPlace.DataLayer.Entities.Wallet;
using Microsoft.AspNetCore.Http;

namespace MarketPlace.Application.Services.Interfaces
{
    public interface IProductService : IAsyncDisposable
    {
        #region products
        List<ProductCategory> GetAllGroup();
        Tuple<List<ShowCourseListItemViewModel>, int> GetCourse(int pageId = 1, string filter = "", string getType = "all",
             string orderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null);
        Task<FilterProductDTO> FilterProducts(FilterProductDTO filter);
 
        Task<CreateProductResult> CreateProduct(CreateProductDTO product, long sellerId, IFormFile productImage);
        Task<bool> AcceptSellerProduct(long productId);
        Task<bool> SendMoneyForSeller(long productId);
        Task<bool> RejectSellerProduct(RejectItemDTO reject);
        Task<bool> RejectSellerSendEmail(RejectItemDTO reject);
        Task<EditProductDTO> GetProductForEdit(long productId);
        Task<EditProductResult> EditSellerProduct(EditProductDTO product, long userId, IFormFile productImage);
        Task RemoveAllProductSelectedCategories(long productId);
        Task RemoveAllProductSelectedColors(long productId);
        Task AddProductSelectedColors(long productId, List<CreateProductColorDTO> colors);
        Task AddProductSelectedCategories(long productId, List<long> selectedCategories);
        Task<List<Product>> FilterProductsForSellerByProductName(long sellerId, string productName);
        Task<List<ProductDiscount>> GetAllOffProducts(int take);
        Task<List<Product>> GetAllProducts(int take);
        Task<List<OrderDetail>> GetAllOrderDetails(int take);
       
        Task<List<TitleBasket>> GetAllTBaskets(int take);
        Task<List<Order>> GetAllOrders(int take);
        Task<List<About>> GetAllAbout(int take);
        Task<List<User>> GetAllTUser(int take);
        Task<List<Seller>> GetAllSeller(int take);

        #endregion

        #region product gallery

        Task<List<ProductGallery>> GetAllProductGalleries(long productId);
        Task<Product> GetProductBySellerOwnerId(long productId, long userId);
        Task<List<ProductGallery>> GetAllProductGalleriesInSellerPanel(long productId, long sellerId);
        Task<CreateOrEditProductGalleryResult> CreateProductGallery(CreateOrEditProductGalleryDTO gallery, long productId, long sellerId);
        Task<CreateOrEditProductGalleryDTO> GetProductGalleryForEdit(long galleryId, long sellerId);
        Task<CreateOrEditProductGalleryResult> EditProductGallery(long galleryId, long sellerId,
            CreateOrEditProductGalleryDTO gallery);
        Task<ProductDetailDTO> GetProductDetailById(long productId);
        //Task<BlogDetailDTO> GetBlogDetailById(long productId);
        Blog GetBlogForShow(long productId);

        #endregion

        #region product categories

        Task<List<ProductCategory>> GetAllProductCategoriesByParentId(long? parentId);
        Task<List<ProductCategory>> GetAllActiveProductCategories();
        Task<List<Product>> GetCategoryProductsByCategoryName(string categoryName, int count = 12);
        Task<ProductCategory> GetProductCategoryByUrlName(string productCategoryUrlName);

        #endregion

        #region product feature

        Task CreateProductFeatures(long productId, List<CreateProductFeatureDTO> features);
        Task RemoveAllProductFeatures(long productId);

        #endregion
    }
}