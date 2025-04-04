namespace RazorPageApp.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public required int UserId { get; set; }
        public required DateTime OrderDate { get; set; }
        public required decimal TotalAmount { get; set; }
        public required string ShippingAddressID { get; set; }
        public required string PaymentMethod {  get; set; }
        public required string OrderStatus { get; set; }
    }
}
