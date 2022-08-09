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

        public void EditPost(FeedPost editedPost)
        {
            var post = _context.FeedPosts.Find(editedPost.Id);

            post.Created = editedPost.Created;
            post.Title = editedPost.Title;
            post.Location = editedPost.Location;
            post.Image = editedPost.Image;

            _context.SaveChanges();
        }
    }
}
