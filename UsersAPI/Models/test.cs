using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Models
{
    //Emil
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("FirstName/{firstName}")]
        public IActionResult GetByFirstName(string firstName)
        {
            // Example: return the received firstName in the response
            return Ok(new { FirstName = firstName });
        }
    }
}
