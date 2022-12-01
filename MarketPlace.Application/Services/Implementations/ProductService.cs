using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Application.Extensions;
using MarketPlace.Application.Senders;
using MarketPlace.Application.Services.Interfaces;
using MarketPlace.Application.Utils;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.DTOs;
using MarketPlace.DataLayer.DTOs.Common;
using MarketPlace.DataLayer.DTOs.Paging;
using MarketPlace.DataLayer.DTOs.Products;
using MarketPlace.DataLayer.Entities.Abouts;
using MarketPlace.DataLayer.Entities.Account;
using MarketPlace.DataLayer.Entities.Mazholar;
using MarketPlace.DataLayer.Entities.ProductOrder;
using MarketPlace.DataLayer.Entities.Products;
using MarketPlace.DataLayer.Entities.Store;
using MarketPlace.DataLayer.Entities.Wallet;
using MarketPlace.DataLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        #region constructor

        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<About> _aboutRepository;
        private readonly IGenericRepository<Seller> _sellerRepository;
        private readonly IGenericRepository<SellerWallet> _sellerWalletRepository;
        private readonly IGenericRepository<ProductCategory> _productCategoryRepository;
        private readonly IGenericRepository<ProductSelectedCategory> _productSelectedCategoryRepository;
        private readonly IGenericRepository<ProductColor> _productColorRepository;
        private readonly IGenericRepository<ProductGallery> _productGalleryRepository;
        private readonly IGenericRepository<TitleBasket> _titlebasketRepository;
        private readonly IGenericRepository<ProductFeature> _productFeatureRepository;
        private readonly IGenericRepository<ProductDiscount> _prodductDiscountRepository;
        private readonly IGenericRepository<User> _userRepository;
        private IViewRenderService _viewRender;
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<OrderDetail> _orderDetailRepository;


        private MarketPlaceDbContext _context;

        public ProductService(IGenericRepository<Product> productRepository,IGenericRepository<About> AboutRepository, IGenericRepository<OrderDetail> orderDetailRepository, IGenericRepository<Seller> sellerRepository, IGenericRepository<SellerWallet> sellerWalletRepository, IViewRenderService viewRender, IGenericRepository<Order> orderRepository, MarketPlaceDbContext context, IGenericRepository<ProductCategory> productCategoryRepository, IGenericRepository<User> userRepository, IGenericRepository<TitleBasket> titlebasketRepository, IGenericRepository<ProductSelectedCategory> productSelectedCategoryRepository, IGenericRepository<ProductColor> productColorRepository, IGenericRepository<ProductGallery> productGalleryRepository, IGenericRepository<ProductFeature> productFeatureRepository, IGenericRepository<ProductDiscount> prodductDiscountRepository)
        {
            _productRepository = productRepository;
            _aboutRepository = AboutRepository;
            _sellerRepository = sellerRepository;
            _sellerWalletRepository = sellerWalletRepository;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _productCategoryRepository = productCategoryRepository;
            _productSelectedCategoryRepository = productSelectedCategoryRepository;
            _productColorRepository = productColorRepository;
            _productGalleryRepository = productGalleryRepository;
            _productFeatureRepository = productFeatureRepository;
            _prodductDiscountRepository = prodductDiscountRepository;
            _titlebasketRepository = titlebasketRepository;
            _userRepository = userRepository;
            _viewRender = viewRender;
            _context = context;
        }

        #endregion

        #region products

        public async Task<CreateProductResult> CreateProduct(CreateProductDTO product, long sellerId, IFormFile productImage)
        {
            if (productImage == null) return CreateProductResult.HasNoImage;

            var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(productImage.FileName);

            var res = productImage.AddImageToServer(imageName, PathExtension.ProductImageServer, 150, 150, PathExtension.ProductThumbnailImageImageServer);

            if (res)
            {
                // create product
                var newProduct = new Product
                {
                    Title = product.Title,
                    Price = product.Price,
                    ShortDescription = product.ShortDescription,
                    Description = product.Description,
                    SiteProfit=product.SiteProfit,
                    IsActive = product.IsActive,
                    Placement = product.Placement,
                    SellerId = sellerId,
                    ImageName = imageName,
                    ProductAcceptanceState = ProductAcceptanceState.UnderProgress
                };

                await _productRepository.AddEntity(newProduct);
                await _productRepository.SaveChanges();

                await AddProductSelectedCategories(newProduct.Id, product.SelectedCategories);
                await AddProductSelectedColors(newProduct.Id, product.ProductColors);
                await _productSelectedCategoryRepository.SaveChanges();

                return CreateProductResult.Success;
            }

            return CreateProductResult.Error;
        }

        public async Task<bool> AcceptSellerProduct(long productId)
        {
            var product = await _productRepository.GetEntityById(productId);
            if (product != null)
            {
                product.ProductAcceptanceState = ProductAcceptanceState.Accepted;
           
                product.ProductAcceptOrRejectDescription = $"محصول مورد نظر در تاریخ {DateTime.Now.ToShamsi()} مورد تایید سایت قرار گرفت";
                _productRepository.EditEntity(product);
                await _productRepository.SaveChanges();
                return true;
            }

            return false;
        }


        public async Task<bool> SendMoneyForSeller(long productId)
        {
            var product = await _sellerWalletRepository.GetEntityById(productId);
            if (product != null)
            {
                product.TransactionType = TransactionType.Withdrawal;
                //product.ProductAcceptOrRejectDescription = $"محصول مورد نظر در تاریخ {DateTime.Now.ToShamsi()} مورد تایید سایت قرار گرفت";
                _sellerWalletRepository.EditEntity(product);
                await _sellerWalletRepository.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<bool> RejectSellerProduct(RejectItemDTO reject)
        {
            var product = await _productRepository.GetEntityById(reject.Id);
            //var products = await _productRepository.GetEntityById(productId);
            if (product != null)
            {

                product.ProductAcceptanceState = ProductAcceptanceState.Rejected;
                product.ProductAcceptOrRejectDescription = reject.RejectMessage;


                _productRepository.EditEntity(product);
                await _productRepository.SaveChanges();

                return true;
            }

            return false;
        }
        public async Task<bool> RejectSellerSendEmail(RejectItemDTO reject)
        {
            var products = await _productRepository.GetEntityById(reject.Id);
            //var products = await _productRepository.GetEntityById(productId);
            if (products != null)
            {

                #region Give user In seller
                // var userSeller = _sellerRepository.GetEntityById(product.SellerId);
                var product = _context.Products.Where(g => g.Id == reject.Id);//Error Get Product
                var getprodduct = product.Where(g => g.Id == reject.Id).SingleOrDefault();
                var user = _context.Users.ToList();
                var seller = _context.Sellers.ToList();
                var Getseller = seller.Where(g => g.Id == getprodduct.SellerId).SingleOrDefault();
                var UserInSeller = user.Where(g => g.Id == Getseller.UserId).SingleOrDefault();
                #endregion

                #region send email
                string body = _viewRender.RenderToStringAsync("_detailsEmail", reject);
                SendEmail.Send(UserInSeller.Email, "عدم تایید محصول", body);

                #endregion


                return true;
            }

            return false;
        }

        public async Task<EditProductDTO> GetProductForEdit(long productId)
        {
            var product = await _productRepository.GetEntityById(productId);
            if (product == null) return null;

            return new EditProductDTO
            {
                Id = productId,
                Description = product.Description,
                ShortDescription = product.ShortDescription,
                Price = product.Price,
                IsActive = product.IsActive,
                Placement = product.Placement,
                ImageName = product.ImageName,
                Title = product.Title,
                ProductColors = await _productColorRepository
                    .GetQuery().AsQueryable()
                    .Where(s => !s.IsDelete && s.ProductId == productId)
                    .Select(s => new CreateProductColorDTO { Price = s.Price, ColorName = s.ColorName, ColorCode = s.ColorCode }).ToListAsync(),
                SelectedCategories = await _productSelectedCategoryRepository.GetQuery().AsQueryable()
                    .Where(s => s.ProductId == productId).Select(s => s.ProductCategoryId).ToListAsync(),
                ProductFeatures = await _productFeatureRepository.GetQuery().AsQueryable()
                    .Where(s => !s.IsDelete && s.ProductId == productId)
                    .Select(f => new CreateProductFeatureDTO
                    {
                        FeatureValue = f.FeatureValue,
                        Feature = f.FeatureTitle
                    }).ToListAsync()
            };
        }

        public async Task<EditProductResult> EditSellerProduct(EditProductDTO product, long userId, IFormFile productImage)
        {
            var mainProduct = await _productRepository.GetQuery().AsQueryable()
                .Include(s => s.Seller)
                .SingleOrDefaultAsync(s => s.Id == product.Id);
            if (mainProduct == null) return EditProductResult.NotFound;
            if (mainProduct.Seller.UserId != userId) return EditProductResult.NotForUser;

            mainProduct.Title = product.Title;
            mainProduct.ShortDescription = product.ShortDescription;
            mainProduct.Description = product.Description;
            mainProduct.IsActive = product.IsActive;
            mainProduct.Price = product.Price;
            mainProduct.Placement = product.Placement;
            mainProduct.ProductAcceptanceState = ProductAcceptanceState.UnderProgress;

            if (productImage != null)
            {
                var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(productImage.FileName);

                var res = productImage.AddImageToServer(imageName, PathExtension.ProductImageServer, 150, 150,
                    PathExtension.ProductThumbnailImageImageServer, mainProduct.ImageName);

                if (res)
                {
                    mainProduct.ImageName = imageName;
                }
            }

            await RemoveAllProductSelectedCategories(product.Id);
            await AddProductSelectedCategories(product.Id, product.SelectedCategories);
            await _productSelectedCategoryRepository.SaveChanges();
            await RemoveAllProductSelectedColors(product.Id);
            await AddProductSelectedColors(product.Id, product.ProductColors);
            await RemoveAllProductFeatures(product.Id);
            await CreateProductFeatures(product.Id, product.ProductFeatures);
            await _productColorRepository.SaveChanges();

            return EditProductResult.Success;
        }

        public async Task RemoveAllProductSelectedCategories(long productId)
        {
            _productSelectedCategoryRepository.DeletePermanentEntities(await _productSelectedCategoryRepository.GetQuery().AsQueryable().Where(s => s.ProductId == productId).ToListAsync());
        }

        public async Task RemoveAllProductSelectedColors(long productId)
        {
            _productColorRepository.DeletePermanentEntities(await _productColorRepository.GetQuery().AsQueryable().Where(s => s.ProductId == productId).ToListAsync());
        }

        public async Task AddProductSelectedColors(long productId, List<CreateProductColorDTO> colors)
        {
            if (colors != null && colors.Any())
            {
                var productSelectedColors = new List<ProductColor>();

                foreach (var productColor in colors)
                {
                    if (productSelectedColors.All(s => s.ColorName != productColor.ColorName))
                    {
                        productSelectedColors.Add(new ProductColor
                        {
                            ColorName = productColor.ColorName,
                            Price = productColor.Price,
                            ProductId = productId,
                            ColorCode = productColor.ColorCode
                        });
                    }
                }

                await _productColorRepository.AddRangeEntities(productSelectedColors);
            }
        }

        public async Task AddProductSelectedCategories(long productId, List<long> selectedCategories)
        {
            if (selectedCategories != null && selectedCategories.Any())
            {
                var productSelectedCategories = new List<ProductSelectedCategory>();

                foreach (var categoryId in selectedCategories)
                {
                    productSelectedCategories.Add(new ProductSelectedCategory
                    {
                        ProductCategoryId = categoryId,
                        ProductId = productId
                    });
                }
                await _productSelectedCategoryRepository.AddRangeEntities(productSelectedCategories);
            }
        }

        public async Task<List<Product>> FilterProductsForSellerByProductName(long sellerId, string productName)
        {
            return await _productRepository.GetQuery()
                .AsQueryable()
                .Where(s =>
                    s.SellerId == sellerId &&
                    EF.Functions.Like(s.Title, $"%{productName}%")).ToListAsync();
        }

        public async Task<List<ProductDiscount>> GetAllOffProducts(int take)
        {
            return await _prodductDiscountRepository.GetQuery().AsQueryable()
                .Include(s => s.Product)
                .Where(s => s.ExpireDate >= DateTime.Now)
                .OrderByDescending(s => s.ExpireDate)
                .Skip(0)
                .Take(take)
                .Distinct()
                .ToListAsync();
        }

        public async Task<List<Product>> GetAllProducts(int take)
        {
            return await _productRepository.GetQuery().AsQueryable()
                .OrderByDescending(s => s.Id)
                .Where(g => g.IsActive == true)
                .Skip(0)
                .Take(take)
                .Distinct()
                .ToListAsync();
        }

        public async Task<List<OrderDetail>> GetAllOrderDetails(int take)
        {
            return await _orderDetailRepository.GetQuery().AsQueryable()
                .OrderByDescending(s => s.Id)
                .Skip(0)
                .Take(take)
                .Distinct()
                .ToListAsync();
        }
        
        public async Task<List<About>> GetAllAbout(int take)
        {
            return await _aboutRepository.GetQuery().AsQueryable()
                .OrderByDescending(s => s.Id)
                .Skip(0)
                .Take(take)
                .Distinct()
                .ToListAsync();
        }

        public async Task<List<TitleBasket>> GetAllTBaskets(int take)
        {
            return await _titlebasketRepository.GetQuery().AsQueryable()

                .Skip(0)
                .Take(take)
                .Distinct()
                .ToListAsync();
        }
        public async Task<List<Order>> GetAllOrders(int take)
        {
            return await _orderRepository.GetQuery().AsQueryable()

                .Skip(0)
                .Take(take)
                .Distinct()
                .ToListAsync();
        }
        public async Task<List<User>> GetAllTUser(int take)
        {
            return await _userRepository.GetQuery().AsQueryable()

                .Skip(0)
                .Take(take)
                .Distinct()
                .ToListAsync();
        }

        public async Task<List<Seller>> GetAllSeller(int take)
        {
            return await _sellerRepository.GetQuery().AsQueryable()

                .Skip(0)
                .Take(take)
                .Distinct()
                .ToListAsync();
        }

        public async Task<FilterProductDTO> FilterProducts(FilterProductDTO filter)
        {
            var query = _productRepository.GetQuery()
                .Include(s => s.ProductSelectedCategories)
                .ThenInclude(s => s.ProductCategory)
                .AsQueryable();

            var expensiveProduct = await query.OrderByDescending(s => s.Price).FirstOrDefaultAsync();
            filter.FilterMaxPrice = expensiveProduct.Price;

            #region state

            switch (filter.FilterProductState)
            {
                case FilterProductState.All:
                    break;
                case FilterProductState.Active:
                    query = query.Where(s => s.IsActive && s.ProductAcceptanceState == ProductAcceptanceState.Accepted);
                    break;
                case FilterProductState.NotActive:
                    query = query.Where(s => !s.IsActive && s.ProductAcceptanceState == ProductAcceptanceState.Accepted);
                    break;
                case FilterProductState.Accepted:
                    query = query.Where(s => s.IsActive && s.ProductAcceptanceState == ProductAcceptanceState.Accepted);
                    break;
                case FilterProductState.Rejected:
                    query = query.Where(s => s.ProductAcceptanceState == ProductAcceptanceState.Rejected);
                    break;
                case FilterProductState.UnderProgress:
                    query = query.Where(s => s.ProductAcceptanceState == ProductAcceptanceState.UnderProgress);
                    break;
            }

            switch (filter.OrderBy)
            {
                case FilterProductOrderBy.CreateData_Des:
                    query = query.OrderByDescending(s => s.CreateDate);
                    break;
                case FilterProductOrderBy.CreateDate_Asc:
                    query = query.OrderBy(s => s.CreateDate);
                    break;
                case FilterProductOrderBy.Price_Des:
                    query = query.OrderByDescending(s => s.Price);
                    break;
                case FilterProductOrderBy.Price_Asc:
                    query = query.OrderBy(s => s.Price);
                    break;
            }

            #endregion

            #region filter

            if (!string.IsNullOrEmpty(filter.ProductTitle))
                query = query.Where(s => EF.Functions.Like(s.Title, $"%{filter.ProductTitle}%"));

            if (filter.SellerId != null && filter.SellerId != 0)
                query = query.Where(s => s.SellerId == filter.SellerId.Value);

            if (filter.SelectedMaxPrice == 0) filter.SelectedMaxPrice = expensiveProduct.Price;

            query = query.Where(s => s.Price >= filter.SelectedMinPrice);
            query = query.Where(s => s.Price <= filter.SelectedMaxPrice);

            if (!string.IsNullOrEmpty(filter.Category))
                query = query.Where(s =>
                    s.ProductSelectedCategories.Any(f => f.ProductCategory.UrlName == filter.Category));

            #endregion

            #region paging

            var pager = Pager.Build(filter.PageId, await query.CountAsync(), filter.TakeEntity, filter.HowManyShowPageAfterAndBefore);
            var allEntities = await query.Paging(pager).ToListAsync();

            #endregion

            return filter.SetProducts(allEntities).SetPaging(pager);

        }



        public List<ProductCategory> GetAllGroup()
        {
            return _productCategoryRepository.GetQuery().Include(c => c.ProductSelectedCategories).ToList();
        }

        public Tuple<List<ShowCourseListItemViewModel>, int> GetCourse(int pageId = 1, string filter = ""
         , string getType = "all", string orderByType = "date",
         int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null)
        {


            IQueryable<Product> result = _productRepository.GetQuery();



            switch (getType)
            {
                case "all":
                    break;
                case "buy":
                    {
                        result = result.Where(c => c.Price != 0);
                        break;
                    }
                case "free":
                    {
                        result = result.Where(c => c.Price == 0);
                        break;
                    }

            }

            switch (orderByType)
            {
                case "date":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "updatedate":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
            }

            if (startPrice > 0)
            {
                result = result.Where(c => c.Price > startPrice);
            }

            if (endPrice > 0)
            {
                result = result.Where(c => c.Price < startPrice);
            }


            if (selectedGroups != null && selectedGroups.Any())
            {
                foreach (int groupId in selectedGroups)
                {
                    result = result.Where(c => c.Id == groupId);
                }

            }

            //int skip = (pageId - 1) * take;

            int pageCount = result.Include(c => c.ProductSelectedCategories).Select(c => new ShowCourseListItemViewModel()
            {
                Id = c.Id,
                ImageName = c.ImageName,
                Price = c.Price,
                Title = c.Title,
                ShortDescription = c.ShortDescription
                // TotalTime = new TimeSpan(c.CourseEpisodes.Sum(e => e.EpisodeTime.Ticks))
            }).Count();

            var query = result.Include(c => c.ProductDiscounts)
                .Include(c => c.ProductDiscounts)
                .Select(c => new ShowCourseListItemViewModel()
                {
                    Id = c.Id,
                    ImageName = c.ImageName,
                    Price = c.Price,
                    Title = c.Title,
                }).ToList();

            return Tuple.Create(query, pageCount);
        }

        #endregion

        #region product gallery

        public async Task<List<ProductGallery>> GetAllProductGalleries(long productId)
        {
            return await _productGalleryRepository.GetQuery().AsQueryable()
                .Where(s => s.ProductId == productId).ToListAsync();
        }

        public async Task<Product> GetProductBySellerOwnerId(long productId, long userId)
        {
            return await _productRepository.GetQuery()
                .Include(s => s.Seller)
                .SingleOrDefaultAsync(s => s.Id == productId && s.Seller.UserId == userId);
        }

        public async Task<List<ProductGallery>> GetAllProductGalleriesInSellerPanel(long productId, long sellerId)
        {
            return await _productGalleryRepository.GetQuery()
                .Include(s => s.Product)
                .Where(s => s.ProductId == productId && s.Product.SellerId == sellerId).ToListAsync();
        }

        public async Task<CreateOrEditProductGalleryResult> CreateProductGallery(CreateOrEditProductGalleryDTO gallery, long productId, long sellerId)
        {
            var product = await _productRepository.GetEntityById(productId);
            if (product == null) return CreateOrEditProductGalleryResult.ProductNotFound;
            if (product.SellerId != sellerId) return CreateOrEditProductGalleryResult.NotForUserProduct;
            if (gallery.Image == null || !gallery.Image.IsImage()) return CreateOrEditProductGalleryResult.ImageIsNull;

            var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(gallery.Image.FileName);
            gallery.Image.AddImageToServer(imageName, PathExtension.ProductGalleryImageServer, 100, 100,
                PathExtension.ProductGalleryThumbnailImageServer);

            await _productGalleryRepository.AddEntity(new ProductGallery
            {
                ProductId = productId,
                ImageName = imageName,
                DisplayPriority = gallery.DisplayPriority
            });

            await _productGalleryRepository.SaveChanges();

            return CreateOrEditProductGalleryResult.Success;
        }

        public async Task<CreateOrEditProductGalleryDTO> GetProductGalleryForEdit(long galleryId, long sellerId)
        {
            var gallery = await _productGalleryRepository.GetQuery()
                .Include(s => s.Product)
                .SingleOrDefaultAsync(s => s.Id == galleryId && s.Product.SellerId == sellerId);

            if (gallery == null) return null;

            return new CreateOrEditProductGalleryDTO
            {
                ImageName = gallery.ImageName,
                DisplayPriority = gallery.DisplayPriority
            };
        }

        public async Task<CreateOrEditProductGalleryResult> EditProductGallery(long galleryId, long sellerId, CreateOrEditProductGalleryDTO gallery)
        {
            var mainGallery = await _productGalleryRepository.GetQuery()
                .Include(s => s.Product)
                .SingleOrDefaultAsync(s => s.Id == galleryId);

            if (mainGallery == null) return CreateOrEditProductGalleryResult.ProductNotFound;

            if (mainGallery.Product.SellerId != sellerId) return CreateOrEditProductGalleryResult.NotForUserProduct;

            if (gallery.Image != null && gallery.Image.IsImage())
            {
                var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(gallery.Image.FileName);
                var result = gallery.Image.AddImageToServer(imageName, PathExtension.ProductGalleryImageServer, 100, 100,
                     PathExtension.ProductGalleryThumbnailImageServer, mainGallery.ImageName);
                mainGallery.ImageName = imageName;
            }

            mainGallery.DisplayPriority = gallery.DisplayPriority;
            _productGalleryRepository.EditEntity(mainGallery);
            await _productGalleryRepository.SaveChanges();
            return CreateOrEditProductGalleryResult.Success;
        }

        public async Task<ProductDetailDTO> GetProductDetailById(long productId)
        {
            var product = await _productRepository.GetQuery()
                .AsQueryable()
                .Include(s => s.Seller)
                .ThenInclude(s => s.User)
                .Include(s => s.ProductSelectedCategories)
                .ThenInclude(s => s.ProductCategory)
                .Include(s => s.ProductGalleries)
                .Include(s => s.ProductColors)
                .Include(s => s.ProductFeatures)
                .SingleOrDefaultAsync(s => s.Id == productId);

            if (product == null) return null;

            var selectedCategoriesIds = product.ProductSelectedCategories.Select(f => f.ProductCategoryId).ToList();

            return new ProductDetailDTO
            {
                ProductId = productId,
                Price = product.Price,
                ImageName = product.ImageName,
                Description = product.Description,
                ShortDescription = product.ShortDescription,
                Seller = product.Seller,
                ProductCategories = product.ProductSelectedCategories.Select(s => s.ProductCategory).ToList(),
                ProductGalleries = product.ProductGalleries.ToList(),
                Title = product.Title,
                ProductColors = product.ProductColors.ToList(),
                SellerId = product.SellerId,
                ProductFeatures = product.ProductFeatures.ToList(),
                RelatedProducts = await _productRepository.GetQuery()
                    .Include(s => s.ProductSelectedCategories)
                    .Where(s => s.ProductSelectedCategories.Any(f => selectedCategoriesIds.Contains(f.ProductCategoryId)) && s.Id != productId && s.ProductAcceptanceState == ProductAcceptanceState.Accepted)
                    .ToListAsync()
            };
        }

        public Blog GetBlogForShow(long productId)
        {
            //var product = await _blogRepository.GetQuery()
            //    .SingleOrDefaultAsync(s => s.Id == productId);

            //if (product == null) return null;

            //return new BlogDetailDTO
            //{
            //    Id = productId,
            //    Text = product.Text,
            //    ImageName = product.ImageName,
            //    Title = product.Title,
            //    ShortDescription = product.ShortDescription,
            //    Writer = product.Writer,
            //    RelatedBlogs = await _blogRepository.GetQuery()
            //    .Where(s => s.Id != productId)
            //    .ToListAsync()

            //};
            if (_context.blogs.Any(c => c.Id == productId))
            {
                return _context.blogs

               .FirstOrDefault(c => c.Id == productId);
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region product categories

        public async Task<List<ProductCategory>> GetAllProductCategoriesByParentId(long? parentId)
        {
            if (parentId == null || parentId == 0)
            {
                return await _productCategoryRepository.GetQuery()
                    .AsQueryable()
                    .Where(s => !s.IsDelete && s.IsActive && s.ParentId == null)
                    .ToListAsync();
            }

            return await _productCategoryRepository.GetQuery()
                .AsQueryable()
                .Where(s => !s.IsDelete && s.IsActive && s.ParentId == parentId)
                .ToListAsync();
        }

        public async Task<List<ProductCategory>> GetAllActiveProductCategories()
        {
            return await _productCategoryRepository.GetQuery().AsQueryable()
                .Where(s => s.IsActive && !s.IsDelete).ToListAsync();
        }

        public async Task<List<Product>> GetCategoryProductsByCategoryName(string categoryName, int count = 12)
        {
            var category = await _productCategoryRepository.GetQuery().SingleOrDefaultAsync(s => s.UrlName == categoryName);
            if (category == null) return null;
            return await _productSelectedCategoryRepository.GetQuery()
                .AsQueryable()
                .Include(s => s.Product)
                .Where(s => s.ProductCategoryId == category.Id && s.Product.IsActive && !s.Product.IsDelete)
                .Select(s => s.Product)
                .OrderByDescending(s => s.CreateDate)
                .Distinct()
                .Take(count)
                .ToListAsync();
        }

        public async Task<ProductCategory> GetProductCategoryByUrlName(string productCategoryUrlName)
        {
            return await _productCategoryRepository.GetQuery()
                .AsQueryable()
                .SingleOrDefaultAsync(s => s.UrlName == productCategoryUrlName);
        }

        #endregion

        #region product feature

        public async Task CreateProductFeatures(long productId, List<CreateProductFeatureDTO> features)
        {
            var newFeatures = new List<ProductFeature>();
            if (features != null && features.Any())
            {
                foreach (var feature in features)
                {
                    newFeatures.Add(new ProductFeature()
                    {
                        ProductId = productId,
                        FeatureTitle = feature.Feature,
                        FeatureValue = feature.FeatureValue
                    });
                }

                await _productFeatureRepository.AddRangeEntities(newFeatures);
                await _productFeatureRepository.SaveChanges();
            }
        }

        public async Task RemoveAllProductFeatures(long productId)
        {
            var productFeatures = await _productFeatureRepository.GetQuery()
                .Where(s => s.ProductId == productId)
                .ToListAsync();

            _productFeatureRepository.DeletePermanentEntities(productFeatures);
            await _productFeatureRepository.SaveChanges();
        }

        #endregion


        #region dispose

        public async ValueTask DisposeAsync()
        {
            await _productCategoryRepository.DisposeAsync();
            await _productRepository.DisposeAsync();
            await _productSelectedCategoryRepository.DisposeAsync();
            await _productFeatureRepository.DisposeAsync();
            await _productSelectedCategoryRepository.DisposeAsync();
            await _productColorRepository.DisposeAsync();
        }


        #endregion
    }
}
