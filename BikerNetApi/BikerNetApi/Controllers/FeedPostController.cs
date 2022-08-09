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
        public async Task<ActionResult<List<FeedPost>>> GetAll()
        {
            var posts = await _service.GetAllPosts();
            return Ok(posts);
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<FeedPost>> Get(Guid id)
        //{
        //    var post = _service.
        //    return Ok(post);
        //}

        //[HttpPost]
        //public async Task<ActionResult<List<FeedPost>>> CreatePost(FeedPost post) // add [FromBody] Attribute for native data types
        //{
        //    _service.FeedPosts.Add(post);
        //    await _service.SaveChangesAsync();
        //    return Ok(await _service.FeedPosts.ToListAsync());
        //}

        //[HttpPut]
        //public async Task<ActionResult<List<FeedPost>>> EditPost(FeedPost editedPost) // add [FromBody] Attribute for native data types
        //{ 
        //    var post = await _service.FeedPosts.FindAsync(editedPost.Id);
        //    post.Created = editedPost.Created;
        //    post.Title = editedPost.Title;
        //    post.Location = editedPost.Location;
        //    post.Image = editedPost.Image;

        //    await _service.SaveChangesAsync();
        //    return Ok(await _service.FeedPosts.ToListAsync());
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<List<FeedPost>>> Delete(Guid id)
        //{
        //    var post = await _service.FeedPosts.FindAsync(id);
        //    _service.FeedPosts.Remove(post);
        //    await _service.SaveChangesAsync();
        //    return Ok(await _service.FeedPosts.ToListAsync());
        //}
    }
}
