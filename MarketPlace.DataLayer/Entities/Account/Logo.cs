using MarketPlace.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.Entities.Account
{
    public class Logo : BaseEntity
    {
        [Required]
        [Display(Name = "عکس")]
        [MaxLength(50)]
        public string Imagename { get; set; }
    }
}
