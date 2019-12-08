using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EpiStore.Core.Entities
{
    public class Category
    {
        public Category()
        {
            Children = new Collection<Category>();
            Products = new Collection<Product>();
        }
        
        public bool Enabled { get; set; }

        public string SKU { get; set; }

        public Category Parent { get; set; }

        public ICollection<Category> Children { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}