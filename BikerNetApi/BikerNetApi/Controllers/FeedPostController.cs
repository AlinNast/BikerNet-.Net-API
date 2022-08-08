using BikerNetApi.Data;
using BikerNetApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikerNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedPostController : ControllerBase
    {
        private DataContext _context { get; set; }

        public FeedPostController(DataContext dataContext)
        {
            _context = dataContext;
        }
    
        [HttpGet]
        public async Task<ActionResult<List<FeedPost>>> Get()
        {
            var posts = await _context.FeedPosts.ToListAsync();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FeedPost>> Get(Guid id)
        {
            var post = _context.FeedPosts.FindAsync(id);
            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult<List<FeedPost>>> CreatePost(FeedPost post) // add [FromBody] Attribute for native data types
        {
            _context.FeedPosts.Add(post);
            await _context.SaveChangesAsync();
            return Ok(await _context.FeedPosts.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<FeedPost>>> EditPost(FeedPost editedPost) // add [FromBody] Attribute for native data types
        { 
            var post = await _context.FeedPosts.FindAsync(editedPost.Id);
            post.Created = editedPost.Created;
            post.Title = editedPost.Title;
            post.Location = editedPost.Location;
            post.Image = editedPost.Image;

            await _context.SaveChangesAsync();
            return Ok(await _context.FeedPosts.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<FeedPost>>> Delete(Guid id)
        {
            var post = await _context.FeedPosts.FindAsync(id);
            _context.FeedPosts.Remove(post);
            await _context.SaveChangesAsync();
            return Ok(await _context.FeedPosts.ToListAsync());
        }
    }
}
