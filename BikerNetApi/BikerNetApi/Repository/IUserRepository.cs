using BikerNetApi.Models;

namespace BikerNetApi.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUser(string username);
        void CreateUser(User user);

        Task<User> GetUserById(Guid Id);
    }
}
