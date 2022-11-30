namespace MobileShop.Infrastructure.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using MobileShop.Infrastructure.Data.Identity;

    public class MobileShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public MobileShopDbContext(DbContextOptions<MobileShopDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Manufacturer> Manufactures { get; set; }
        public DbSet<Accessory> Accessories { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}