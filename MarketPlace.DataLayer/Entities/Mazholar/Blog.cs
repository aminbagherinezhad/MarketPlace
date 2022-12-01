using MarketPlace.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.Entities.Mazholar
{
    public class Blog :BaseEntity
    {
        [Required]
        [MaxLength(150)]
        [Display(Name = "عنوان بلاگ")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "نویسنده")]
        [MaxLength(50)]
        public string Writer { get; set; }
        [Required]
        [Display(Name = "خلاصه متن")]
        [MaxLength(350)]
        public string ShortDescription { get; set; }
        [Required]
        [Display(Name = "متن اصلی")]
        public string Text { get; set; }
        [Required]
        [Display(Name = "عکس")]
        [MaxLength(150)]
        public string ImageName { get; set; }
    }
}
