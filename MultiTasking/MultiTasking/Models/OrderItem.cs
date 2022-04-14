namespace MultiTasking.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public int Count { get; set; }
        public GreenGrocer vegetable { get; set; }
    }
}
