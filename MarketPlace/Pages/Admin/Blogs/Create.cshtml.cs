using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Mazholar;
using MarketPlace.DataLayer.DTOs.Admin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace MarketPlace.Pages.Admin.Blogs
{
    public class CreateModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public CreateModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BlogAddEdiViewModel CG { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public IFormFile UploadImage { get; set; }
        public ActionResult OnPost([FromServices] IWebHostEnvironment env)
        {
            if (!ModelState.IsValid)
                return Page();
            var pro = new Blog()
            {
               Writer=CG.Writer,
               Title=CG.Title,
               Text=CG.Text,
               ShortDescription=CG.ShortDescription
            };

            CG.Id = pro.Id;
            CG.LastUpdateDate = DateTime.Now;
            CG.CreateDate = DateTime.Now;
            CG.IsDelete = false;
            _context.SaveChanges();

            var filePath = Path.Combine(env.WebRootPath, "Blog", CG.ImageName.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                CG.ImageName.CopyTo(stream);
                pro.ImageName = CG.ImageName.FileName;
            }

            _context.Add(pro);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
