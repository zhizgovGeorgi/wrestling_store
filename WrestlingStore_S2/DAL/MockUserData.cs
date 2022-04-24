using System;
using System.Collections.Generic;
using System.Text;
using Modules;

namespace DAL
{
    public class MockUserData : IUserDataManagement<User>
    {
        public void AddUser(User entity)
        {
            List<User> users = new List<User>();
            users.Add(entity);
        }

        public void DeleteUser(User entity)
        {
            List<User> users = new List<User>();
            users.Add(entity);
            users.Remove(entity);
        }

        public bool EditUserr(User entity)
        {
            return true;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            //User u1 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            //users.Add(u1);
            //User u2 = new User(2, "Ivan", "Ivanov", "ivan@abv.bg", "prostor", "1234", "User");
            //users.Add(u2);
            //User u23 = new User(23, "Ivan", "Ivanov", "rangel@abv.bg", "prostor", "1234", "User");
            //users.Add(u23);
            //User u4 = new User(4, "a4o", "a4kov", "angel@abv.bg", "prostor", "1234", "User");
            //users.Add(u4);

            return users;
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

       

        public void EditUser(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
