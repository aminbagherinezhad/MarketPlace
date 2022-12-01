using MarketPlace.DataLayer.Entities.Account;
using MarketPlace.DataLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.DataLayer.Entities.Products
{
    public class ProductDiscountUse : BaseEntity
    {
        #region properties
        [Display(Name = "شناسه محصول تخفیف خورده")]
        public long ProductDiscountId { get; set; }
        [Display(Name = "شناسه کاربر")]
        public long UserId { get; set; }

        #endregion

        #region relations

        public User User { get; set; }
        public ProductDiscount ProductDiscount { get; set; }

        #endregion
    }
}
