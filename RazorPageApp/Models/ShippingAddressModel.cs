namespace RazorPageApp.Models
{
    public class ShippingAddressModel
    {
        public int Id { get; set; }
        public required int UserId { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string Region { get; set; }
        public required string PostalCode { get; set; }
        public required string Country { get; set; }
    }
}
