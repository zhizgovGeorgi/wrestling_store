using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>();
        }


        public User GetUser(string email, string password)
        {
            foreach (User user in users)
            {
                if (user.email == email && user.password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(int id, string FName, string LName, string Email, string Adress, string Password, string Role)
        {
            users.Add(new User(id, FName, LName, Email, Adress, Password, Role));
        }

        public void AddAdmin(int id, string FName, string LName, string Email, string Adress, string Password)
        {
            users.Add(new User(id, FName, LName, Email, Adress, Password, "Administrator"));
        }

        public void RemoveUser(User u)
        {
            foreach (User user in users)
            {
                if (u.id == user.id)
                {
                    users.Remove(u);
                    return;
                }
            }
            
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
