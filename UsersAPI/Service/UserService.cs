using UsersAPI.Repository;
namespace UsersAPI.Service
{
    public class UserService
    {
        public void DeleteUser(int userId)
        {
            var repository = new UserRepository();
            repository.DeleteUser(userId);
        }
    }
}
