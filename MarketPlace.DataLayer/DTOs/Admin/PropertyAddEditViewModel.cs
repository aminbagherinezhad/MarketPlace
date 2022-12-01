using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.DTOs.Admin
{
    public class PropertyAddEditViewModel
    {
        public long Id { get; set; }
        public IFormFile Imagename { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
