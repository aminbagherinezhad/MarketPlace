using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.Wallet;

namespace MarketPlace.Pages.Admin.WalletSellers
{
    public class DetailsModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public DetailsModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
