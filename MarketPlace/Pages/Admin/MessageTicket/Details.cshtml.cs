using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Contacts;

namespace MarketPlace.Pages.Admin.MessageTicket
{
    public class DetailsModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public DetailsModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        public TicketMessage TicketMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TicketMessage = await _context.TicketMessages
                .Include(t => t.Sender)
                .Include(t => t.Ticket).FirstOrDefaultAsync(m => m.Id == id);

            if (TicketMessage == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
