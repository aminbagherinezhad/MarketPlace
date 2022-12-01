using MarketPlace.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.Entities.Mazholar
{
    public class Social : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        [Display(Name = "ایکون")]
        public string Icon { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "لینک سایت")]
        public string Href { get; set; }
        [Required]
        [Display(Name = "کلاس")]
        [MaxLength(250)]
        public string Class { get; set; }
    }
}
