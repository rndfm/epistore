namespace EpiStore.Core.Entities
{
    public class Product
    {
        public Product()
        {
            Categories = new Collection<Category>();
        }

        public int Id { get; set; }

        /// <summary>
        /// Unique product identifier.
        /// </summary>
        public string SKU { get; set; }

        public bool Enabled { get; set; }

        public ICollection<Category> Categories { get; set; }

        // TODO: Add properties for multilanguage fields. Eg. Product name in multiple languages.
    }
}