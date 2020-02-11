using Microsoft.AspNetCore.Identity;
using Shop.Database;
using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.UsersAdmin
{
    public class UpdateUser
    {
        private UserManager<IdentityUser> _userManager;
        private Claim newClaim;
        private ApplicationDbContext _context;

        public UpdateUser(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Do(Request request)
        {
            HashAlgorithm hashAlgorithm = HashAlgorithm.Create("sha256");
            var user = _context.Users.FirstOrDefault(x => x.Id.Equals(request.Id));

            user.Id = request.Id;
            user.UserName = request.Username;
            user.PasswordHash = Convert.ToBase64String(hashAlgorithm.ComputeHash(Encoding.Unicode.GetBytes(request.Password)));

            // get a list of old claims for the current user
            var oldClaims = await _userManager.GetClaimsAsync(user);

            // if current user has been given admin access rights, assign admin claim
            if (request.Role.Equals("Admin"))
            {
                newClaim = new Claim("Role", "Admin");
            }
            // else if current user has been given manager access rights, assign manager claim
            else if (request.Role.Equals("Manager"))
            {
                newClaim = new Claim("Role", "Manager");
            }

            // iteratively remove each claim from current user
            foreach(var oldClaim in oldClaims)
            {
                await _userManager.RemoveClaimAsync(user, oldClaim);
            }

            // apply new claim to current user and save changes
            await _userManager.AddClaimAsync(user, newClaim);
            await _context.SaveChangesAsync();

            return new Response
            {
                Id = user.Id,
                Username = user.UserName,
                Password = user.PasswordHash,
                Role = request.Role
            };
        }

        public class Request
        {
            public string Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        public class Response
        {
            public string Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }
    }
}
