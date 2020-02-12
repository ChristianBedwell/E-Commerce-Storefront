using Microsoft.AspNetCore.Identity;
using Shop.Database;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Shop.Application.UsersAdmin
{
    public class Response
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }

    public class GetUsers
    {
        private readonly ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;

        public GetUsers(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // iterate through user claims and retrieve first claim
        public async Task<string> getUserRoleAsync(IdentityUser user)
        {
            List<Claim> claimsList = new List<Claim>();

            // get a list of claims for the current user
            var claims = await _userManager.GetClaimsAsync(user);

            foreach(var claim in claims)
            {
                claimsList.Add(claim);
            }

            return claimsList[0].Value;
        }

        public IEnumerable<Response> Do() =>
            _context.Users.ToList().Select(x => new Response
            {
                Id = x.Id,
                Username = x.UserName,
                PasswordHash = x.PasswordHash
            });
    }
}
