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
        private Claim userClaim;

        public CreateUser(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public class Request
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        public async Task<bool> Do(Request request)
        {
            HashAlgorithm hashAlgorithm = HashAlgorithm.Create("sha256");

            var newUser = new IdentityUser()
            {
                UserName = request.Username,
                PasswordHash = Convert.ToBase64String(hashAlgorithm.ComputeHash(Encoding.Unicode.GetBytes(request.Password)))
            };

            await _userManager.CreateAsync(newUser, request.Password);

            // if new user has admin access rights, assign admin claim
            if (request.Role.Equals("Admin"))
            {
                userClaim = new Claim("Role", "Admin");
            }
            // else if new user has manager access rights, assign manager claim
            else if (request.Role.Equals("Manager"))
            {
                userClaim = new Claim("Role", "Manager");
            }            
            // apply claim to user
            await _userManager.AddClaimAsync(newUser, userClaim);

            return true;
        }
    }
}
