using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.UsersAdmin
{
    public class CreateUser
    {
        private UserManager<IdentityUser> _userManager;

        public CreateUser(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public class Request
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public async Task<bool> Do(Request request)
        {
            HashAlgorithm hashAlgorithm = HashAlgorithm.Create("sha256");

            var managerUser = new IdentityUser()
            {
                UserName = request.Username,
                PasswordHash = Convert.ToBase64String(hashAlgorithm.ComputeHash(Encoding.Unicode.GetBytes(request.Password)))
            };

            await _userManager.CreateAsync(managerUser, request.Password);

            var managerClaim = new Claim("Role", "Manager");

            await _userManager.AddClaimAsync(managerUser, managerClaim);

            return true;
        }
    }
}
