using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Account;
using MarketPlace.DataLayer.DTOs.Admin;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace MarketPlace.Pages.Admin.Logos
{
    public class EditModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public EditModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LogoAddEditViewModel CG { get; set; }
        [BindProperty]
        public IFormFile UploadImage { get; set; }
        public void OnGet(int id)
        {
            var Gallerys = _context.Logos.ToList()
                .Where(p => p.Id == id)
                .Select(s => new LogoAddEditViewModel()
                {
                    Id = s.Id,
                  
                }).FirstOrDefault();

            Gallerys = CG;
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var product = _context.Logos.Find(CG.Id);


            _context.SaveChanges();
            if (CG.Imagename?.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "Logo",
                    product.Id + Path.GetExtension(CG.Imagename.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    CG.Imagename.CopyTo(stream);
                }
            }

            return RedirectToPage("Index");
        }
    }
}
