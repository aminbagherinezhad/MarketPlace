using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MarketPlace.DataLayer.Entities.Common;

namespace MarketPlace.DataLayer.Entities.ProductOrder
{
    public class Order : BaseEntity
    {
        #region properties
        [Display(Name = "شناسه کاربر")]
        public long UserId { get; set; }
        [Display(Name = "زمان واریز")]
        public DateTime? PaymentDate { get; set; }
        [Display(Name = "تاییده واریز")]
        public bool IsPaid { get; set; }

        [Display(Name = "کد پیگیری")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string TracingCode { get; set; }

        [Display(Name = "کد پیگیری")]
        public string Description { get; set; }

        #endregion

        #region relations

        public ICollection<OrderDetail> OrderDetails { get; set; }

        #endregion
    }
}
