using MarketPlace.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.Entities.Mazholar
{
    public class License:BaseEntity
    {
        [Required]
        [Display(Name = "عکس")]
        [MaxLength(150)]
        public string ImageName { get; set; }
        [Required]
        [Display(Name = "لینک سایت")]
        [MaxLength(150)]
        public string Href { get; set; }
    }
}
