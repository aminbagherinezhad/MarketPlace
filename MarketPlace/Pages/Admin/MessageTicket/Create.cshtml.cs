using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Contacts;

namespace MarketPlace.Pages.Admin.MessageTicket
{
    public class CreateModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public CreateModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SenderId"] = new SelectList(_context.Users, "Id", "EmailActiveCode");
        ViewData["TicketId"] = new SelectList(_context.Tickets, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public TicketMessage TicketMessage { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TicketMessages.Add(TicketMessage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
