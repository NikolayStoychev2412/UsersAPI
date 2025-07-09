using UsersAPI.Models;

namespace UsersAPI.Repository
{
    public class UserRepository
    {
        public List<UserModel> users;
        public void RegisterUser(int userId) //string userFirstName, string userLastName
        {
            //pass some of the user properties as parameters from the endpoint
            users.Add(new UserModel { Id = userId, City="Plovdiv", FirstName= "userFirstName" });
        }

        public void UpdateUser(string city, int id)
        {
            users.Add(new UserModel { Id = 1, City = "Plovdiv", FirstName = "Ivan" });
            users.Add(new UserModel { Id = 2, City = "Sofia", FirstName = "Dragan" });
            ///.......
            //iterate all users, find the one with the id and update its hometown
        }

        public void DeleteUser(int id)
        {
            users.Add(new UserModel { Id = 1, City = "Plovdiv", FirstName = "Ivan" });
            users.Add(new UserModel { Id = 2, City = "Sofia", FirstName = "Dragan" });
            ///.......
            //iterate all users, find the one with the id and delete it
        }
    }
}
