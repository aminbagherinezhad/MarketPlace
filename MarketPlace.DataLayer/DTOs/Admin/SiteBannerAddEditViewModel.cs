using MarketPlace.DataLayer.Entities.Site;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.DTOs.Admin
{
    public class SiteBannerAddEditViewModel
    {
        public long Id { get; set; }
        public IFormFile ImageName { get; set; }
        public string Url { get; set; }
        public string ColSize { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public BannerPlacement BannerPlacement { get; set; }
    }
}
