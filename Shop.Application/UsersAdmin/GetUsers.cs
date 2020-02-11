using Shop.Database;
using System.Collections.Generic;
using System.Linq;

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

        public GetUsers(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Response> Do() =>
            _context.Users.ToList().Select(x => new Response
            {
                Id = x.Id,
                Username = x.UserName,
                PasswordHash = x.PasswordHash,
            });
    }
}
