using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.DTOs
{
    public class ShowCourseListItemViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public int Price { get; set; }
        public bool IsDelete { get; set; }
    }
}
