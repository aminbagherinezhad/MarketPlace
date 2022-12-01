using MarketPlace.DataLayer.Entities.Common;
using MarketPlace.DataLayer.Entities.Products;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.DataLayer.Entities.ProductOrder
{
    public class OrderDetail : BaseEntity
    {
        #region properties
        [Display(Name = "شناسه سفارش")]
        public long OrderId { get; set; }
        [Display(Name = "شناسه محصول")]
        public long ProductId { get; set; }
        [Display(Name = "شناسه رنگ محصول")]
        public long? ProductColorId { get; set; }
        [Display(Name = "تعداد")]
        public int Count { get; set; }
        [Display(Name = "قیمت محصول")]
        public int ProductPrice { get; set; }
        [Display(Name = "قیمت اضافی رنگ محصول")]
        public int ProductColorPrice { get; set; }

        #endregion

        #region relations

        public Order Order { get; set; }

        public Product Product { get; set; }

        public ProductColor ProductColor { get; set; }

        #endregion
    }
}
