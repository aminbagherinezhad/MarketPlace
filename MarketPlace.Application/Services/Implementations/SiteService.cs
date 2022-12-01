using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Application.Services.Interfaces;
using MarketPlace.DataLayer.Entities.Account;
using MarketPlace.DataLayer.Entities.Mazholar;
using MarketPlace.DataLayer.Entities.Products;
using MarketPlace.DataLayer.Entities.Site;
using MarketPlace.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Application.Services.Implementations
{
    public class SiteService : ISiteService
    {
        #region constructor

        private readonly IGenericRepository<SiteSetting> _siteSettingRepository;
        private readonly IGenericRepository<Slider> _sliderRepository;
        private readonly IGenericRepository<SiteBanner> _bannerRepository;
        private readonly IGenericRepository<Property> _propertyRepository;
        private readonly IGenericRepository<Logo> _logoRepository;
        private readonly IGenericRepository<Social> _socialRepository;
        private readonly IGenericRepository<ProductCategory> _categoryRepository;
        private readonly IGenericRepository<Contact> _contactRepository;
        private readonly IGenericRepository<Blog> _BlogRepository;
        private readonly IGenericRepository<License> _licesRepository;

        public SiteService(IGenericRepository<SiteSetting> siteSettingRepository, IGenericRepository<Slider> sliderRepository, IGenericRepository<License> licesRepository, IGenericRepository<Blog> BlogRepository, IGenericRepository<Contact> contactRepository, IGenericRepository<ProductCategory> categoryRepository, IGenericRepository<Social> socialRepository, IGenericRepository<Logo> logoRepository, IGenericRepository<Property> propertyRepository, IGenericRepository<SiteBanner> bannerRepository)
        {
            _siteSettingRepository = siteSettingRepository;
            _sliderRepository = sliderRepository;
            _bannerRepository = bannerRepository;
            _propertyRepository = propertyRepository;
            _logoRepository = logoRepository;
            _socialRepository = socialRepository;
            _categoryRepository = categoryRepository;
            _contactRepository = contactRepository;
            _BlogRepository = BlogRepository;
            _licesRepository = licesRepository;
        }

        #endregion

        #region site settings

        public async Task<SiteSetting> GetDefaultSiteSetting()
        {
            return await _siteSettingRepository.GetQuery().AsQueryable()
                .SingleOrDefaultAsync(s => s.IsDefault && !s.IsDelete);
        }

        #endregion

        #region slider

        public async Task<List<Slider>> GetAllActiveSliders()
        {
            return await _sliderRepository.GetQuery().AsQueryable()
                .Where(s => s.IsActive && !s.IsDelete).ToListAsync();
        }

        #endregion

        #region site banners

        public async Task<List<SiteBanner>> GetSiteBannersByPlacement(List<BannerPlacement> placements)
        {
            return await _bannerRepository.GetQuery().AsQueryable()
                .Where(s => placements.Contains(s.BannerPlacement)).ToListAsync();
        }

        #endregion

        #region Home Property

        public async Task<List<Property>> GetAllProperty()
        {
            return await _propertyRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete).ToListAsync();
        }

        #endregion

        #region Logo

        public async Task<List<Logo>> GetLogo()
        {
            return await _logoRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete).ToListAsync();
        }

        #endregion

        #region Social

        public async Task<List<Social>> GetSocial()
        {
            return await _socialRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete).ToListAsync();
        }
        #endregion

        #region Category

        public async Task<List<ProductCategory>> GetCategory()
        {
            return await _categoryRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete).ToListAsync();
        }

        #endregion

        #region Blog

        public async Task<List<Blog>> GetBlog()
        {
            return await _BlogRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete).OrderByDescending(g=>g.Id).ToListAsync();
        }

        #endregion

        #region Lices

        public async Task<List<License>> GetLices()
        {
            return await _licesRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete).ToListAsync();
        }

        #endregion

        #region Contact

        public async Task<List<Contact>> GetContact()
        {
            return await _contactRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete).ToListAsync();
        }

        #endregion
        #region dispose

        public async ValueTask DisposeAsync()
        {
            if (_siteSettingRepository != null) await _siteSettingRepository.DisposeAsync();
            if (_sliderRepository != null) await _sliderRepository.DisposeAsync();
            if (_bannerRepository != null) await _bannerRepository.DisposeAsync();
        }

        #endregion
    }
}
