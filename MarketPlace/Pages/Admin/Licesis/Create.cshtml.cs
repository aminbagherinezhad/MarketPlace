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

namespace MarketPlace.Pages.Admin.Licesis
{
    public class CreateModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public CreateModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LiceseAddEditViewModel CG { get; set; }
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
            var pro = new License()
            {
               Href=CG.Href,
               
            };

            CG.Id = pro.Id;
            CG.LastUpdateDate = DateTime.Now;
            CG.CreateDate = DateTime.Now;
            CG.IsDelete = false;
            _context.SaveChanges();

            var filePath = Path.Combine(env.WebRootPath, "Liceses", CG.Imagename.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                CG.Imagename.CopyTo(stream);
                pro.ImageName = CG.Imagename.FileName;
            }

            _context.Add(pro);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
