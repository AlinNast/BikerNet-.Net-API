using BikerNetApi.Data;
using BikerNetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BikerNetApi.Repository
{
    public class FeedPostRepository : IFeedPostRepository
    {
        private readonly DataContext _context;

        public FeedPostRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<FeedPost>> GetAllPosts()
        {
            var posts = await _context.FeedPosts.ToListAsync();
            return posts;
        }

        public void CreatePost(FeedPost post)
        {
            _context.FeedPosts.Add(post);
            _context.SaveChanges();
        }
    }
}
