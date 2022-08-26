using BikerNetApi.Models;
using BikerNetApi.Repository;

namespace BikerNetApi.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepository)
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

        public async Task<string> GetUserById(string Id)
        {
            Guid guid = Guid.Empty;
            guid = Guid.Parse(Id);
            var user = await _userRepo.GetUserById(guid);
            return user.UserName;
        }
    }
}
