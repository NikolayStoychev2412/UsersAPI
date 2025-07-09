using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using UsersAPI.Service;

namespace UsersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("RegisterUser")]
        public ActionResult Get(int userId)
        {
            var service = new UserService();
            service.RegisterUser(userId);

            return Ok();
        }

        [HttpGet("UpdateUser")]
        public ActionResult UpdateUser(int userId, string homeTown)
        {
            var service = new UserService();
            //service.UpdateUser(userId);

            return Ok();
        }

        [HttpGet("DeleteUser")]
        public ActionResult DeleteUser(int userId)
        {
            var service = new UserService();
            //service.DeleteUser(userId);

            return Ok();
        }
    }
}
