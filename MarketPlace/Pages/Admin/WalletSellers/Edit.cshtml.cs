using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Wallet;

namespace MarketPlace.Pages.Admin.WalletSellers
{
    public class EditModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public EditModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SellerWallet SellerWallet { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SellerWallet = await _context.SellerWallets
                .Include(s => s.Seller).FirstOrDefaultAsync(m => m.Id == id);

            if (SellerWallet == null)
            {
                return NotFound();
            }
           ViewData["SellerId"] = new SelectList(_context.Sellers, "Id", "Address");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SellerWallet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SellerWalletExists(SellerWallet.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SellerWalletExists(long id)
        {
            return _context.SellerWallets.Any(e => e.Id == id);
        }
    }
}
