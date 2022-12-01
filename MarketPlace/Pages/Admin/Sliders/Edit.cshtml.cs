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
using MarketPlace.DataLayer.DTOs.Admin;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace MarketPlace.Pages.Admin.Sliders
{
    public class EditModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public EditModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SliderAddEditViewModel CG { get; set; }
        [BindProperty]
        public IFormFile UploadImage { get; set; }
        public void OnGet(int id)
        {
            var Gallerys = _context.Sliders.ToList()
                .Where(p => p.Id == id)
                .Select(s => new SliderAddEditViewModel()
                {
                    Id = s.Id,
                    Description = s.Description,
                    Link = s.Link,
                    MainHeader = s.MainHeader,
                    SecondHeader = s.SecondHeader,
                    IsActive = s.IsActive,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = s.IsDelete
                }).FirstOrDefault();

            Gallerys = CG;
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var product = _context.Sliders.Find(CG.Id);

            product.Link = CG.Link;
            product.Description = CG.Description;
            product.SecondHeader = CG.SecondHeader;
            product.MainHeader = CG.MainHeader;
            product.IsActive = CG.IsActive;
            product.IsDelete = CG.IsDelete;

            _context.SaveChanges();
            if (CG.ImageName?.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "Slider",
                    product.Id + Path.GetExtension(CG.ImageName.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    CG.ImageName.CopyTo(stream);
                }
            }

            return RedirectToPage("Index");
        }
    }
}
