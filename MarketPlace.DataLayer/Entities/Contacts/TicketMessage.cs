﻿using System.ComponentModel.DataAnnotations;
using MarketPlace.DataLayer.Entities.Account;
using MarketPlace.DataLayer.Entities.Common;

namespace MarketPlace.DataLayer.Entities.Contacts
{
    public class TicketMessage : BaseEntity
    {
        #region properties

        [Display(Name = "شناسه تیکت")]
        public long TicketId { get; set; }

        [Display(Name = "شناسه فرسنده")]

        public long SenderId { get; set; }

        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Text { get; set; }

        #endregion

        #region relations

        public Ticket Ticket { get; set; }

        public User Sender { get; set; }

        #endregion
    }
}
