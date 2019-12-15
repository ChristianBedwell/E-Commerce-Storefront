using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;

namespace VideoGameShop.UI.Pages
{
    public class ProductModel : PageModel
    {
        private ApplicationDbContext _context;

        public ProductModel(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public GetProduct.ProductViewModel Product { get; set; }

        public IActionResult OnGet(string name)
        {
            Product = new GetProduct(_context).Do(name.Replace("-", " "));
            if (Product == null)
            {
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
