using BikerNetApi.Data;
using BikerNetApi.Models;
using Microsoft.EntityFrameworkCore;

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
            var users = await _context.Users.ToListAsync<User>();
            foreach (User user in users)
            {
                if (user.UserName == username)
                {
                    return user;
                }
            }
                return null;
        }
    }
}
