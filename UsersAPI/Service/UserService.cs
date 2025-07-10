using UsersAPI.Repository;
namespace UsersAPI.Service
{
    public class UserService
    {
        public void RegisterUser(int userId)
        {
            var repo = new UserRepository();
            repo.RegisterUser(userId);

        }
        public void DeleteUser(int userId)
        {
            var repository = new UserRepository();
            repository.DeleteUser(userId);
        }

        public void UpdateUser(string city, int id, string newCity)
        {
            var userRepository = new UserRepository();
            userRepository.UpdateUser(city, id, newCity);
        }
    }
}
