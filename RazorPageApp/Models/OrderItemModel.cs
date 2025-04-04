namespace RazorPageApp.Models
{
    public class OrderItemModel
    {
        public int Id { get; set; }
        public required int OrderId { get; set; }
        public required int ProductId { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
    }
}
