using UsersAPI.Models;

namespace UsersAPI.Repository
{
    public class UserRepository
    {
        public List<UserModel> Users = new List<UserModel>();
        public void DeleteUser(int userId)
        {
            foreach (var user in Users)
            {
                if (user.Id == userId)
                {
                    Users.Remove(user);
                    break;
                }
            }
        }
    }
}
