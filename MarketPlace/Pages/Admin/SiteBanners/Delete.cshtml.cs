using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Site;
using System.IO;

namespace MarketPlace.Pages.Admin.SiteBanners
{
    public class DeleteModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public DeleteModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SiteBanner SiteBanner { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SiteBanner = await _context.SiteBanners.FirstOrDefaultAsync(m => m.Id == id);

            if (SiteBanner == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            var product = _context.SiteBanners.Find(SiteBanner.Id);


            _context.SiteBanners.Remove(product);

            _context.SaveChanges();

            string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot",
                "SiteBanner",
                product.ImageName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }


            return RedirectToPage("./Index");
        }
    }
}
