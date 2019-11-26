namespace EpiStore.Core.Entities
{
    public class OrderLine
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}