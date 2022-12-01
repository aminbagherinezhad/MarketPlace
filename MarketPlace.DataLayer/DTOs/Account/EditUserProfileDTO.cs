﻿using System.ComponentModel.DataAnnotations;
namespace MarketPlace.DataLayer.DTOs.Account
{
    public class EditUserProfileDTO
    {
        public long UserId { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string LastName { get; set; }
        
        [Display(Name = "آدرس")]
      
        public string Address { get; set; }
        
        [Display(Name = "ایمیل")]
      
        public string Email { get; set; }

        [Display(Name = "تصویر آواتار")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Avatar { get; set; }
    }

    public enum EditUserProfileResult
    {
        NotFound,
        IsBlocked,
        IsNotActive,
        Success
    }
}
