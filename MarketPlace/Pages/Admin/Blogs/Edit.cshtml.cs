using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Mazholar;
using Microsoft.AspNetCore.Http;
using MarketPlace.DataLayer.DTOs.Admin;
using System.IO;

namespace MarketPlace.Pages.Admin.Blogs
{
    public class EditModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public EditModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }
        //[BindProperty]
        //public BlogAddEdiViewModel CG { get; set; }
        [BindProperty]
        public IFormFile UploadImage { get; set; }
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
            if (!ModelState.IsValid)
                return Page();

            var product = _context.blogs.Find(Blog.Id);

            product.Title = Blog.Title;
            product.ShortDescription = Blog.ShortDescription;
            product.Text = Blog.Text;
            product.Writer = Blog.Writer;

            product.IsDelete = Blog.IsDelete;
            product.CreateDate = Blog.CreateDate;
            product.LastUpdateDate = Blog.LastUpdateDate;

            //_context.SaveChanges();
            //if (CG.ImageName?.Length > 0)
            //{
            //    string filePath = Path.Combine(Directory.GetCurrentDirectory(),
            //        "wwwroot",
            //        "Blog",
            //        product.Id + Path.GetExtension(CG.ImageName.FileName));
            //    using (var stream = new FileStream(filePath, FileMode.Create))
            //    {
            //        CG.ImageName.CopyTo(stream);
            //    }
            //}

            return RedirectToPage("Index");
        }

       
    }
}
