using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketPlace.DataLayer.Context;
using MarketPlace.DataLayer.Entities.ProductOrder;

namespace MarketPlace.Pages.Admin.OrderDetails
{
    public class IndexModel : PageModel
    {
        private readonly MarketPlace.DataLayer.Context.MarketPlaceDbContext _context;

        public IndexModel(MarketPlace.DataLayer.Context.MarketPlaceDbContext context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; }

        public async Task OnGetAsync()
        {
            OrderDetail = await _context.OrderDetails
                .Include(o => o.Order)
                .Include(o => o.Product)
                .Include(o => o.ProductColor).ToListAsync();
        }
    }
}
