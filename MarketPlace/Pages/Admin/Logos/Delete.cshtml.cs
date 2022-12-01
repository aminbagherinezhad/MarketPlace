using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Account;
using System.IO;

namespace MarketPlace.Pages.Admin.Logos
{
    public class DeleteModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public DeleteModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Logo Logo { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Logo = await _context.Logos.FirstOrDefaultAsync(m => m.Id == id);

            if (Logo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            var product = _context.Logos.Find(Logo.Id);


            _context.Logos.Remove(product);

            _context.SaveChanges();

            string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot",
                "Logo",
                product.Imagename);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }


            return RedirectToPage("./Index");
        }
    }
}
