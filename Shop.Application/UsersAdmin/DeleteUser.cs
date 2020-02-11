using Shop.Database;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Application.UsersAdmin
{
    public class DeleteUser
    {
        private ApplicationDbContext _context;

        public DeleteUser(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Do(string id)
        {
            var User = _context.Users.FirstOrDefault(x => x.Id.Equals(id));
            _context.Users.Remove(User);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
