using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.CreateProducts;
using Shop.Application.GetProducts;
using Shop.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VideoGameShop.UI.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Shop.Application.CreateProducts.ProductViewModel Product { get; set; }
        public IEnumerable<Shop.Application.GetProducts.ProductViewModel> Products { get; set; }
       
        public void OnGet()
        {
            Products = new GetProducts(_context).Do();
        }

        public async Task<IActionResult> onPost()
        {
            await new CreateProduct(_context).Do(Product);
            return RedirectToPage("Index");
        }
    }
}
