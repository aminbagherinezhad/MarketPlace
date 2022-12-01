using MarketPlace.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.Entities.Mazholar
{
    public class Property :BaseEntity
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "عکس")]
        public string ImageName { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "متن")]
        public string Text { get; set; }    
    }
}
