using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.DTOs.Admin
{
    public class SliderAddEditViewModel
    {
        public long Id { get; set; }
        public string MainHeader { get; set; }
        public string SecondHeader { get; set; }
        public IFormFile ImageName { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
