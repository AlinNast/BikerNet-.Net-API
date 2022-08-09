using BikerNetApi.Models;

namespace BikerNetApi.Service
{
    public interface IFeedPostService
    {
        Task<List<FeedPost>> GetAllPosts();
        Task<FeedPost> GetPost(Guid id);
        void CreatePost(FeedPost post);
        void EditPost(FeedPost editedPost);

    }
}
