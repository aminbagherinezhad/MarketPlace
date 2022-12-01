using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Mazholar;

namespace MarketPlace.Pages.Admin.Socials
{
    public class DeleteModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public DeleteModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Social Social { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Social = await _context.Socials.FirstOrDefaultAsync(m => m.Id == id);

            if (Social == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Social = await _context.Socials.FindAsync(id);

            if (Social != null)
            {
                _context.Socials.Remove(Social);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
