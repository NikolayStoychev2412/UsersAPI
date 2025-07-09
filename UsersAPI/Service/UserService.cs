using UsersAPI.Repository;

namespace UsersAPI.Service
{
    public class UserService
    {
        public  void RegisterUser(int userId)
        {
            var repo = new UserRepository();
            repo.RegisterUser(userId);

        }

        //..add methods for update and delete
    }
}
