using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Wallet;

namespace MarketPlace.Pages.Admin.WalletSellers
{
    public class CreateModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public CreateModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SellerId"] = new SelectList(_context.Sellers, "Id", "StoreName");
            return Page();
        }

        [BindProperty]
        public SellerWallet SellerWallet { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SellerWallets.Add(SellerWallet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
