using MarketPlace.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.Entities.Mazholar
{
    public class TitleBasket:BaseEntity
    {
        [Display(Name = "مکان  قرار گیری")]
        public int Placement { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [MaxLength(350)]
        [Display(Name = "خلاصه متن")]
        public string Description { get; set; }
    }
}
