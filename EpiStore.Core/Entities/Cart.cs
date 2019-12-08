using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EpiStore.Core.Entities
{
    public class Cart
    {
        public Cart()
        {
            Items = new Collection<CartItem>();
        }
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public DateTime LastAccessed { get; set; }

        public ICollection<CartItem> Items { get; set; }
    }
}