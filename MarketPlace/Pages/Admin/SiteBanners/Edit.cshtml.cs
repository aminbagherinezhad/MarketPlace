using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MarketPlace.DataLayer.DTOs.Admin;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace MarketPlace.Pages.Admin.SiteBanners
{
    public class EditModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public EditModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public SiteBannerAddEditViewModel CG { get; set; }
        [BindProperty]
        public IFormFile UploadImage { get; set; }
        public void OnGet(int id)
        {
            var Gallerys = _context.SiteBanners.ToList()
                .Where(p => p.Id == id)
                .Select(s => new SiteBannerAddEditViewModel()
                {
                    Id = s.Id,
                    ColSize = s.ColSize,
                    Url = s.Url,
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

            var product = _context.SiteBanners.Find(CG.Id);

            product.Url = CG.Url;
            product.ColSize = CG.ColSize;

            product.IsDelete = CG.IsDelete;

            _context.SaveChanges();
            if (CG.ImageName?.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "SiteBanner",
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
