using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageApp.Models;
using RazorPageApp.Repositories;

namespace RazorPageApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProductContext _context;
        public required List<ProductModel> Products { get; set; } 
        public IndexModel(ILogger<IndexModel> logger, ProductContext context) 
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Products = _context.Products.ToList();
            if (!Products.Any()) 
            {
                //Handle if no Products added to list
                return;
            }

        }
    }
}
