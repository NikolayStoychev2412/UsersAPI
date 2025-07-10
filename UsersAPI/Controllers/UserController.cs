using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersAPI.Repository;
using UsersAPI.Service;

namespace UsersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("RegisterUser")]
        public ActionResult RegisterUser(int userId)
        {
            var repo = new UserService();
            repo.RegisterUser(userId);
            return Ok();
        }

        [HttpDelete("DeleteUser/{userId}")]
        public ActionResult Get(int userId)
        {
            var service = new Service.UserService();
            service.DeleteUser(userId);
            return Ok();
        }

        [HttpPut ("UpdateUser/City-{city}/ID-{id}")]

        public ActionResult Put(string city, int id, string newCity)
        {
            var service = new Service.UserService();
            service.UpdateUser(city, id, newCity);

            return Ok();
        }
    }
}
