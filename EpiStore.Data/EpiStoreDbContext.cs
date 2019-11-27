namespace EpiStore.Data
{
    public class EpiStoreDbContext : DbContext
    {
        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Cart> Carts { get; set; }

         public EpiStoreDbContext(DbContextOptions<EpiStoreDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new CartConfiguration());

            builder
                .ApplyConfiguration(new CartItemConfiguration());
        }
    }
}