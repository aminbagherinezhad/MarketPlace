﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Contacts;

namespace MarketPlace.Pages.Admin.Tickets
{
    public class IndexModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public IndexModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        public IList<Ticket> Ticket { get;set; }

        public async Task OnGetAsync()
        {
            Ticket = await _context.Tickets
                .Include(t => t.Owner).ToListAsync();
        }
    }
}
