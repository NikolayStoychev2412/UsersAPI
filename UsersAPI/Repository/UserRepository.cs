﻿using UsersAPI.Models;

namespace UsersAPI.Repository
{
    public class UserRepository
    {
        public List<UserModel> Users = new List<UserModel>();
        public void RegisterUser(int userId) //string userFirstName, string userLastName
        {
            //pass some of the user properties as parameters from the endpoint
            Users.Add(new UserModel { Id = userId, City = "Plovdiv", FirstName = "userFirstName" });
        }
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

        public void UpdateUser(string city, int id, string newCity)
        {
            foreach (var user in Users)
            {
                if (user.City == city && user.Id == id)
                {
                    user.City = newCity;
                    break;
                }
            }
        }


    }
}
