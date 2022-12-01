using MarketPlace.DataLayer.DTOs.Paging;
using MarketPlace.DataLayer.Entities.Mazholar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.DTOs.Products
{
    public class FilterBloga : BasePaging
    {
        #region constructor

        public FilterBloga()
        {
            OrderBy = FilterProductOrderBy.CreateData_Des;
        }

        #endregion

        #region properteis

        public string Title { get; set; }
        public string Description { get; set; }





        public FilterProductState FilterProductState { get; set; }

        public FilterProductOrderBy OrderBy { get; set; }

        public List<Blog> Blogs { get; set; }


        #endregion

        #region methods

        public FilterBloga SetProducts(List<Blog> products)
        {
            this.Blogs = products;
            return this;
        }

        public FilterBloga SetPaging(BasePaging paging)
        {
            this.PageId = paging.PageId;
            this.AllEntitiesCount = paging.AllEntitiesCount;
            this.StartPage = paging.StartPage;
            this.EndPage = paging.EndPage;
            this.HowManyShowPageAfterAndBefore = paging.HowManyShowPageAfterAndBefore;
            this.TakeEntity = paging.TakeEntity;
            this.SkipEntity = paging.SkipEntity;
            this.PageCount = paging.PageCount;
            return this;
        }

        #endregion
    }

    public enum FilterBlogState
    {
        [Display(Name = "همه")]
        All,
        [Display(Name = "در حال بررسی")]
        UnderProgress,
        [Display(Name = "تایید شده")]
        Accepted,
        [Display(Name = "رد شده")]
        Rejected,
        [Display(Name = "فعال")]
        Active,
        [Display(Name = "غیر فعال")]
        NotActive
    }

    public enum FilterBlogOrderBy
    {
        [Display(Name = "تاریخ ( نزولی )")]
        CreateData_Des,
        [Display(Name = "تاریخ ( صعودی )")]
        CreateDate_Asc,
        [Display(Name = "قیمت ( نزولی )")]
        Price_Des,
        [Display(Name = "قیمت ( صعودی )")]
        Price_Asc,
    }
}
