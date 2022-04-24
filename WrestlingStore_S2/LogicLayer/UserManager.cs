
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


        public User ReadUser(string email, string password)
        {
            return users.Find(x => x.Email == email && x.Password == password);
        }

        public void AddUser(User user)
        {
            if (users.Find(x => x.Email == user.Email) is null)
            {
                userDataManagement.AddUser(user);
                users.Add(user);
            }
        }


        public void RemoveUser(User u)
        {
            if (users.Find(x => x.Email == u.Email) != null)
            {
                userDataManagement.DeleteUser(u);
                users.Remove(u);

            }
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
