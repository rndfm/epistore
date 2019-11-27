namespace EpiStore.Core.Entities
{
    public class CartItem
    {
        public int Id { get; set; }

        public int CartId { get; set; }
        
        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}