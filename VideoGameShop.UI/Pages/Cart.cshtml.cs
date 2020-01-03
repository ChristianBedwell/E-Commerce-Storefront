using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;
using Shop.Application.StockAdmin;
using Shop.Database;
using System.Collections.Generic;

namespace VideoGameShop.UI.Pages
{
    public class CartModel : PageModel
    {
        private ApplicationDbContext _context;

        public CartModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GetCart.Response> Cart { get; set; }
        public IEnumerable<GetStock.ProductViewModel> Stock { get; set; }

        public IActionResult OnGet()
        {
            Cart = new GetCart(HttpContext.Session, _context).Do();
            Stock = new GetStock(_context).Do();

            return Page();
        }
    }
}
