using BikerNetApi.Models;

namespace BikerNetApi.Repository
{
    public interface IFeedPostRepository
    {
        Task<List<FeedPost>> GetAllPosts();
        void CreatePost(FeedPost feedPost);
        void EditPost(FeedPost feedPost);
    }
}
