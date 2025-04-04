using System.ComponentModel.DataAnnotations;

namespace RazorPageApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required string ImageURL { get; set; }
        public required string Category { get; set; }
        public required int Stock { get; set; }
        public required string Description { get; set; }
        public required string Weight { get; set; }
        public required decimal Price { get; set; }

    }
}
