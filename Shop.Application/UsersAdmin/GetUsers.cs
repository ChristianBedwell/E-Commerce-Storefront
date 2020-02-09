using Microsoft.EntityFrameworkCore;
using Shop.Database;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Application.UsersAdmin
{
    public class GetUsers
    {
        private ApplicationDbContext _context;

        public GetUsers(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Response> Do() =>
            _context.Users
            .Include(x => x.UserName)
            .Select(x => new Response
            {
                Username = x.UserName,
                PasswordHash = x.PasswordHash
            })
            .ToList();

        public class Response
        {
            public string Username { get; set; }
            public string PasswordHash { get; set; }
        }
    }
}