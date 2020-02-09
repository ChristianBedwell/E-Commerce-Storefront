using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Database;

namespace VideoGameShop.UI.Pages.Admin
{
    public class Response
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }

    public class ConfigureUsersModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Response> users;

        public ConfigureUsersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            users = _context.Users.ToList().Select(x => new Response
                {
                    Username = x.UserName,
                    PasswordHash = x.PasswordHash
                });
        }
    }        
}
