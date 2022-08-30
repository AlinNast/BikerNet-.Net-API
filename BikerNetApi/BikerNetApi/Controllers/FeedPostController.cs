using BikerNetApi.Data;
using BikerNetApi.Models;
using BikerNetApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikerNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedPostController : ControllerBase
    {
        private IFeedPostService _service { get; set; }

        public FeedPostController(IFeedPostService service)
        {
            _service = service;
        }
    
        [HttpGet]
        public async Task<ActionResult<List<FeedPost>>> GetAllPosts()
        {
            var posts = await _service.GetAllPosts();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FeedPost>> GetPost(Guid id)
        {
            var post = await _service.GetPost(id);
            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult<FeedPost>> CreatePost(FeedPost newPost) // add [FromBody] Attribute for native data types
        {
            var post = new FeedPost()
            { Id = Guid.NewGuid(),
            Title = newPost.Title,
            Description = newPost.Description,
            Created = DateTime.Now,
            UserId = newPost.UserId,
            Location = null,
            Image = null,
            };
            _service.CreatePost(post);
            return Ok(post);
        }

        [HttpPut]
        public async Task<ActionResult<FeedPost>> EditPost(FeedPost editedPost) // add [FromBody] Attribute for native data types
        {
            _service.EditPost(editedPost);
            var post = await _service.GetPost(editedPost.Id);
            return Ok(post);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            _service.DeletePost(id);
            return Ok();
        }
    }
}
