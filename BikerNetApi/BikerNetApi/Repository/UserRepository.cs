using BikerNetApi.Data;
using BikerNetApi.Models;

namespace BikerNetApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public async Task<User> GetUser(string username)
        {
            var user = await _context.Users.FindAsync(username);
            return user;
        }
    }
}
