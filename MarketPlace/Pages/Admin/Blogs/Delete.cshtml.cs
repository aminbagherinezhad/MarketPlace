using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Mazholar;
using System.IO;

namespace MarketPlace.Pages.Admin.Blogs
{
    public class DeleteModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public DeleteModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Blog Blog { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog = await _context.blogs.FirstOrDefaultAsync(m => m.Id == id);

            if (Blog == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            var product = _context.blogs.Find(Blog.Id);


            _context.blogs.Remove(product);

            _context.SaveChanges();

            string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot",
                "Blog",
                product.ImageName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }


            return RedirectToPage("./Index");
        }
    }
}
