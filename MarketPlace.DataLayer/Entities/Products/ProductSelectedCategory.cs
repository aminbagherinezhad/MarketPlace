using MarketPlace.DataLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.DataLayer.Entities.Products
{
    public class ProductSelectedCategory : BaseEntity
    {
        #region properties
        [Display(Name = "شناسه محصول")]
        public long ProductId { get; set; }
        [Display(Name = "شناسه گروه")]
        public long ProductCategoryId { get; set; }

        #endregion

        #region relations

        public Product Product { get; set; }

        public ProductCategory ProductCategory { get; set; }

        #endregion
    }
}
