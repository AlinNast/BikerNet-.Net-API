using BikerNetApi.Models;
using BikerNetApi.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BikerNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }


        // GET api/<UserController>/5
        [HttpGet("{username}/{password}")]
        public async Task<IActionResult> LogIn(string username, string password)
        {
            var user = await _service.GetUser(username);
            if (user == null) return NotFound();
            if (user.Password != password) return BadRequest("Wrong Password");
            return Ok();
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            _service.CreateUser(user);
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
