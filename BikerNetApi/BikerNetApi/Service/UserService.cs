using BikerNetApi.Models;
using BikerNetApi.Repository;

namespace BikerNetApi.Service
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepo;

        public UserService(UserRepository userRepository)
        {
            _userRepo = userRepository;
        }
        public void CreateUser(User user)
        {
            _userRepo.CreateUser(user);
        }

        public async Task<User> GetUser(string username)
        {
            var user = await _userRepo.GetUser(username);
            return user;
        }
    }
}
