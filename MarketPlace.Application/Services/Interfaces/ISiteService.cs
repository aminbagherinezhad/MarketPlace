using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MarketPlace.DataLayer.Entities.Account;
using MarketPlace.DataLayer.Entities.Mazholar;
using MarketPlace.DataLayer.Entities.Products;
using MarketPlace.DataLayer.Entities.Site;

namespace MarketPlace.Application.Services.Interfaces
{
    public interface ISiteService : IAsyncDisposable
    {
        #region site settings

        Task<SiteSetting> GetDefaultSiteSetting();

        #endregion

        #region slider

        Task<List<Slider>> GetAllActiveSliders();

        #endregion

        #region Property

        Task<List<Property>> GetAllProperty();

        #endregion

        #region Logo

        Task<List<Logo>> GetLogo();

        #endregion

        #region Social

        Task<List<Social>> GetSocial();

        #endregion

        #region Category

        Task<List<ProductCategory>> GetCategory();

        #endregion

        #region Blog

        Task<List<Blog>> GetBlog();

        #endregion

        #region Lices

        Task<List<License>> GetLices();

        #endregion
        
        #region Contact

        Task<List<Contact>> GetContact();

        #endregion
        
        #region site banners

        Task<List<SiteBanner>> GetSiteBannersByPlacement(List<BannerPlacement> placements);

        #endregion
    }
}