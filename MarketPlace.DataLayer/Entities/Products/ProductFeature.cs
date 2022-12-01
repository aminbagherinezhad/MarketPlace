﻿using System.ComponentModel.DataAnnotations;
using MarketPlace.DataLayer.Entities.Common;

namespace MarketPlace.DataLayer.Entities.Products
{
    public class ProductFeature : BaseEntity
    {
        #region properties

        [Display(Name = "شناسه محصول")]
        public long ProductId { get; set; }

        [Display(Name = "عنوان ویژگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string FeatureTitle { get; set; }

        [Display(Name = "مقدار ویژگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string FeatureValue { get; set; }

        #endregion

        #region relations

        public Product Product { get; set; }

        #endregion
    }
}
