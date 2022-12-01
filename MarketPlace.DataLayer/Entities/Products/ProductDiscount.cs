using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MarketPlace.DataLayer.Entities.Common;

namespace MarketPlace.DataLayer.Entities.Products
{
    public class ProductDiscount : BaseEntity
    {
        #region properties
        [Display(Name = "شناسه محصول")]
        public long ProductId { get; set; }

        [Range(0, 100)]
        [Display(Name = "مقدار تخفیف")]
        public int Percentage { get; set; }
        [Display(Name = "تاریخ انقضا")]
        public DateTime ExpireDate { get; set; }
        [Display(Name = "تعداد")]

        public int DiscountNumber { get; set; }

        #endregion

        #region relations

        public Product Product { get; set; }

        public ICollection<ProductDiscountUse> ProductDiscountUses { get; set; }

        #endregion
    }
}
