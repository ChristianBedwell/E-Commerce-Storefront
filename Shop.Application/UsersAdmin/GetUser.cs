using Microsoft.AspNetCore.Identity;
using Shop.Database;
using System.Linq;

namespace Shop.Application.UsersAdmin
{
    public class GetUser
    {
        private UserManager<IdentityUser> _userManager;
        private ApplicationDbContext _context;

        public GetUser(ApplicationDbContext context)
        {
            _context = context;
        }

        // TODO: iterate through user claims and retrieve first claim
        public void getUserRole()
        {

        }

        public UserViewModel Do(string id) =>
            _context.Users.Where(x => x.Id.Equals(id)).Select(x => new UserViewModel
            {
                Id = x.Id,
                Username = x.UserName,
                Password = x.PasswordHash
            })
            .FirstOrDefault();

        public class UserViewModel
        {
            public string Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }
    }
}
