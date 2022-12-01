using System;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.DataLayer.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        [Display(Name = "شناسه")]
        public long Id { get; set; }
        [Display(Name = "حذف")]
        public bool IsDelete { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime LastUpdateDate { get; set; }
    }
}
