using MarketPlace.DataLayer.Entities.Mazholar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.DTOs.Products
{
    public class BlogDetailDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Writer { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public string ImageName { get; set; }
        public List<Blog> RelatedBlogs { get; set; }

    }
}
