using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageApp.Models;
using RazorPageApp.Repositories;

namespace RazorPageApp.Pages
{
    public class ProductViewModel : PageModel
    {
        private readonly ProductContext _context;
        public required ProductModel Product { get; set; }
        public ProductViewModel(ProductContext context) 
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            Product = _context.Products.Single(x => x.Id == id);
        }
    }
}
