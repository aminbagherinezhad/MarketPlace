using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Abouts;

namespace MarketPlace.Pages.Admin.Abouts
{
    public class DeleteModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public DeleteModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public About About { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            About = await _context.abouts.FirstOrDefaultAsync(m => m.Id == id);

            if (About == null)
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

            About = await _context.abouts.FindAsync(id);

            if (About != null)
            {
                _context.abouts.Remove(About);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
