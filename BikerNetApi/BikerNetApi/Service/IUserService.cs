using BikerNetApi.Models;

namespace BikerNetApi.Service
{
    public interface IUserService
    {
        void CreateUser(User user);

        Task<User> GetUser(string username);
    }
}
