using MarketPlace.DataLayer.DTOs.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DataLayer.DTOs.SellerWallet
{
    public class DetailsSellerDTO : BasePaging
    {
        public long? SellerId { get; set; }

        public int? UserId { get; set; }
        public int? PriceFrom { get; set; }

        public int? PriceTo { get; set; }

        public List<Entities.Wallet.SellerWallet> SellerWallets { get; set; }

        public DetailsSellerDTO SetSellerWallets(List<Entities.Wallet.SellerWallet> wallets)
        {
            SellerWallets = wallets;
            return this;
        }

        public DetailsSellerDTO SetPaging(BasePaging paging)
        {
            this.PageId = paging.PageId;
            this.AllEntitiesCount = paging.AllEntitiesCount;
            this.StartPage = paging.StartPage;
            this.EndPage = paging.EndPage;
            this.HowManyShowPageAfterAndBefore = paging.HowManyShowPageAfterAndBefore;
            this.TakeEntity = paging.TakeEntity;
            this.SkipEntity = paging.SkipEntity;
            this.PageCount = paging.PageCount;

            return this;
        }

    }
}
