using MarketPlace.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.Entities.Abouts
{
    public class About :BaseEntity
    {
        [Required]
        [MaxLength(150)]
        [Display(Name ="عکس")]
        public string ImageName { get; set; }
        [Required]
        [MaxLength(450)]
        [Display(Name = "متن")]
        public string Text { get; set; }
    }
}
