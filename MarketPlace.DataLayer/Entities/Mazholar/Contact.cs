using MarketPlace.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.Entities.Mazholar
{
    public class Contact:BaseEntity
    {
        [Required]
        [MaxLength(250)]
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "آدرس")]
        [MaxLength(150)]
        public string Address { get; set; }
        [Required]
        [Display(Name = "تلفن")]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Display(Name = "ایمیل")]
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
