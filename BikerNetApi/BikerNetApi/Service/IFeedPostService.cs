using BikerNetApi.Models;

namespace BikerNetApi.Service
{
    public interface IFeedPostService
    {
        Task<List<FeedPost>> GetAllPosts();

    }
}
