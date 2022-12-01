using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.DTOs.Admin
{
    public class BlogAddEdiViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Writer { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public IFormFile ImageName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
