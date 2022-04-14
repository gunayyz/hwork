using System.Collections.Generic;
namespace MultiTasking.Models
{
    class Order
    {
        public int Id { get; set; }
        public List<OrderItem> items { get; set; }
    }
}
