using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private UserManager<IdentityUser> _userManager;

        public UsersController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet("")]
        public IActionResult GetUsers() => Ok(new GetUsers(_context, _userManager).Do());

        [HttpGet("{id}")]
        public IActionResult GetUser(string id) => Ok(new GetUser(_context, _userManager).Do(id));

        [HttpPost("")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUser.Request request) => Ok((await new CreateUser(_userManager).Do(request)));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id) => Ok((await new DeleteUser(_context).Do(id)));

        [HttpPut("")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUser.Request request) => Ok((await new UpdateUser(_context, _userManager).Do(request)));
    }
}
