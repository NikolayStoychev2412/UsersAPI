using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("DeleteUser")]
        public ActionResult Get(int userId)
        {
            var service = new Service.UserService();
            service.DeleteUser(userId);
            return Ok();
        }
    }
}
