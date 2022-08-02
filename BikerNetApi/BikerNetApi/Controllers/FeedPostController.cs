using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikerNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedPostController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var posts = new List<FeedPost>
            {
                new FeedPost { Id = new Guid(), Title = "Test" , Created = new DateTime() }
            };
            
            return Ok(posts);
        }
    }
}
