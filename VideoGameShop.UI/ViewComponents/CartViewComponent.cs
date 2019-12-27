using Microsoft.AspNetCore.Mvc;
using Shop.Application.Cart;
using Shop.Database;
using System.Linq;

namespace VideoGameShop.UI.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private ApplicationDbContext _context;

        public CartViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string view = "Default")
        {
            if(view == "Small")
            {
                var totalValue = new GetCart(HttpContext.Session, _context).Do().Sum(x => x.RealValue * x.Qty);
                return View(view, $"${totalValue}");
            }

            return View(view, new GetCart(HttpContext.Session, _context).Do());
        }
    }
}
