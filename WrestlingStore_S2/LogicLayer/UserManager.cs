
using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class UserManager 
    {
        private List<User> users;
        IUserDataManagement<User> userDataManagement;

        public UserManager(IUserDataManagement<User> userDataManagement)
        {
            this.userDataManagement = userDataManagement;
            users = this.userDataManagement.GetAllUsers();
        }


        public User GetUser(string email, string password)
        {
            foreach (User u in users)
            {
                User user = userDataManagement.ReadUser(email, password);
                if (user.Email == u.Email && user.Password == u.Password)
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(User user)
        {
            userDataManagement.AddUser(user);
            users.Add(user);

        }

        public void AddAdmin(User user)
        {
            userDataManagement.AddAdministrator(user);
            users.Add(user);
        }

        public void RemoveUser(User u)
        {
            users.Remove(u);
            userDataManagement.DeleteUser(u);
            return;
        }
        public User GetUser(string email)
        {
            return users.Find(x => x.Email == email);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
