namespace EpiStore.Data.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .UseIdentityColumn();

            builder
                .HasOne(i => i.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(i => i.CartId);

            builder
                .ToTable("CartItems");
        }
    }
}