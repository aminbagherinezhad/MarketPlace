using System.Linq;
using MarketPlace.DataLayer.Entities.Abouts;
using MarketPlace.DataLayer.Entities.Account;
using MarketPlace.DataLayer.Entities.Contacts;
using MarketPlace.DataLayer.Entities.Mazholar;
using MarketPlace.DataLayer.Entities.ProductOrder;
using MarketPlace.DataLayer.Entities.Products;
using MarketPlace.DataLayer.Entities.Site;
using MarketPlace.DataLayer.Entities.Store;
using MarketPlace.DataLayer.Entities.Wallet;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.DataLayer.Context
{
    public class MarketPlaceDbContext : DbContext
    {
        public MarketPlaceDbContext(DbContextOptions<MarketPlaceDbContext> options) : base(options) { }

        #region account

        public DbSet<User> Users { get; set; }
        public DbSet<Logo> Logos { get; set; }

        #endregion

        #region site

        public DbSet<SiteSetting> SiteSettings { get; set; }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SiteBanner> SiteBanners { get; set; }

        #endregion


        #region contacts

        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketMessage> TicketMessages { get; set; }

        #endregion

        #region store

        public DbSet<Seller> Sellers { get; set; }

        #endregion

        #region products

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductGallery> ProductGalleries { get; set; }

        public DbSet<ProductSelectedCategory> ProductSelectedCategories { get; set; }

        public DbSet<ProductColor> ProductColors { get; set; }

        public DbSet<ProductFeature> ProductFeatures { get; set; }

        #endregion

        #region propduct discount

        public DbSet<ProductDiscount> ProductDiscounts { get; set; }

        public DbSet<ProductDiscountUse> ProductDiscountUses { get; set; }

        #endregion

        #region order

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        #endregion

        #region wallet
        public DbSet<SellerWallet> SellerWallets { get; set; }
        #endregion

        #region Mazholar
        public DbSet<Property> properties { get; set; }
        public DbSet<TitleBasket> titleBaskets { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<About> abouts { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=wh1.azaronline.com,1450;Database=MarketPlaceDbContext;User Id=samanmir_microFile;password=%mt0K91y0");
            }
        }

        #region on model creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<Product>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Logo>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SiteSetting>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SiteBanner>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Seller>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductCategory>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductGallery>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductColor>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductFeature>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductDiscount>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductDiscountUse>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderDetail>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SellerWallet>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TitleBasket>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<License>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Blog>()
               .HasQueryFilter(u => !u.IsDelete);
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
