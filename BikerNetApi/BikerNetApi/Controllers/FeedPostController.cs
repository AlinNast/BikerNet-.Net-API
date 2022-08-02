using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikerNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedPostController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<FeedPost>>> Get()
        {
            var posts = new List<FeedPost>
            {
                new FeedPost { Id = new Guid(), Title = "Test" , Created = DateTime.Now }
            };
            
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FeedPost>> Get(Guid id)
        {
            var posts = new List<FeedPost>
            {
                new FeedPost { Id = new Guid(), Title = "Test" , Created = DateTime.Now }
            };
            var post = posts.Find(x => x.Id == id);
            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult<List<FeedPost>>> CreatePost(FeedPost post) // add [FromBody] Attribute for native data types
        {
            var posts = new List<FeedPost>
            {
                new FeedPost { Id = new Guid(), Title = "Test" , Created = DateTime.Now }
            };
            posts.Add(post);
            return Ok(posts);
        }

        [HttpPut]
        public async Task<ActionResult<List<FeedPost>>> EditPost(FeedPost editedPost) // add [FromBody] Attribute for native data types
        {
            var posts = new List<FeedPost>
            {
                new FeedPost { Id = new Guid(), Title = "Test" , Created = DateTime.Now }
            };
            var post = posts.Find(x => x.Id == editedPost.Id);
            post.Created = editedPost.Created;
            post.Title = editedPost.Title;
            post.Location = editedPost.Location;
            post.Image = editedPost.Image;

            posts.Add(post);
            return Ok(posts);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<FeedPost>>> Delete(Guid id)
        {
            var posts = new List<FeedPost>
            {
                new FeedPost { Id = new Guid(), Title = "Test" , Created = DateTime.Now }
            };
            var post = posts.Find(x => x.Id == id);
            posts.Remove(post);
            return Ok(posts);
        }
    }
}
