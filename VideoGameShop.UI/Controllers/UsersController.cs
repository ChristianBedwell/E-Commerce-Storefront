using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.UsersAdmin;
using Shop.Database;
using System.Threading.Tasks;

namespace VideoGameShop.UI.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Admin")]
    public class UsersController : Controller
    {
        private ApplicationDbContext _context;
        private CreateUser _createUser;

        public UsersController(ApplicationDbContext context, CreateUser createUser)
        {
            _context = context;
            _createUser = createUser;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUser.Request request) => Ok((await _createUser.Do(request)));

        [HttpGet("")]
        public IActionResult GetUsers() => Ok(new GetUsers(_context).Do());
    }
}
