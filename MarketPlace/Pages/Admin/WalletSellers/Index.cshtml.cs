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
    public class IndexModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public IndexModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        public IList<SellerWallet> SellerWallet { get;set; }

        public async Task OnGetAsync()
        {
            SellerWallet = await _context.SellerWallets
                .Include(s => s.Seller).ToListAsync();
        }
    }
}
