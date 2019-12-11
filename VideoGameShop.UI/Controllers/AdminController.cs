using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductsAdmin;
using Shop.Database;

namespace VideoGameShop.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new GetProducts(_context).Do());

        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProduct(_context).Do(id));

        [HttpGet("products")]
        public IActionResult CreateProduct(CreateProduct.ProductViewModel viewModel) => Ok(new CreateProduct(_context).Do(viewModel));

        [HttpGet("products/{id}")]
        public IActionResult DeleteProduct(int id) => Ok(new DeleteProduct(_context).Do(id));

        [HttpGet("products")]
        public IActionResult UpdateProduct(UpdateProduct.ProductViewModel viewModel) => Ok(new UpdateProduct(_context).Do(viewModel));
    }
}
