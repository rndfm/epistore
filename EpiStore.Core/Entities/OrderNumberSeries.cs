
namespace EpiStore.Core.Entities
{
    /// <summary>
    /// Order number series is used to create unique order numbers.
    /// Each series must have an unique prefix.
    /// Only one series with empty prefix for simple order numbers. eg. 1,2,3,4...
    /// </summary>
    public class OrderNumberSeries
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Prefix { get; set; }

        /// <summary>
        /// Current value for last increment of the order number.
        /// Next order will get order number Counter + 1
        /// </summary>
        public int Counter { get; set; }
    }
}