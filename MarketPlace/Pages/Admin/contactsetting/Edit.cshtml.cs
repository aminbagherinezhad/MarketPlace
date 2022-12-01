using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Site;

namespace MarketPlace.Pages.Admin.contactsetting
{
    public class EditModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public EditModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SiteSetting SiteSetting { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SiteSetting = await _context.SiteSettings.FirstOrDefaultAsync(m => m.Id == id);

            if (SiteSetting == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SiteSetting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiteSettingExists(SiteSetting.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SiteSettingExists(long id)
        {
            return _context.SiteSettings.Any(e => e.Id == id);
        }
    }
}
