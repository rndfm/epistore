using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EpiStore.Core.Entities
{
    public class Order
    {
        public Order()
        {
            OrderLines = new Collection<OrderLine>();
        }
        
        public int Id { get; set; }

        /// <summary>
        /// Order number is generated at order creation.
        /// Value could be assigned by an auto incrementing order number series generator.
        /// Order number series can be prefixed with a-z characters.
        /// Value must be unique.
        /// </summary>
        /// <value>Must be unique, Eg. 1337, IF1337</value>
        // TODO: Validate string structure for order number series.
        public string OrderNumber { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
    }
}