using BikerNetApi.Models;
using BikerNetApi.Repository;

namespace BikerNetApi.Service
{
    public class FeedPostService : IFeedPostService
    {
        private IFeedPostRepository _postsRepo;

        public FeedPostService(IFeedPostRepository postsRepo)
        {
            _postsRepo = postsRepo;
        }

        public async Task<List<FeedPost>> GetAllPosts()
        {
            var posts = await _postsRepo.GetAllPosts();
            return posts;
        }
    }
}
