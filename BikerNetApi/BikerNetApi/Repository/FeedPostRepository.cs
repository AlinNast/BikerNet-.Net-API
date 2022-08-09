using BikerNetApi.Data;
using BikerNetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BikerNetApi.Repository
{
    public class FeedPostRepository : IFeedPostRepository
    {
        private readonly DataContext _context;
        public async Task<List<FeedPost>> GetAllPosts()
        {
            var posts = await _context.FeedPosts.ToListAsync();
            return posts;
        }
    }
}
