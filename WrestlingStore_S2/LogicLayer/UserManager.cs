using DAL;
using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class UserManager
    {
        private UserData ud;
        private List<User> users;

        public UserManager()
        {
            ud = new UserData();
            users = ud.GetAllUsers() ;
        }


        public User GetUser(string email, string password)
        {
            foreach (User u in users)
            {
                    User user = ud.ReadUser(email, password);
                if (user.email == u.email && user.password == u.password)
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(string FName, string LName, string Email, string Adress, string Password)
        {
            ud.AddUser(FName, LName, Email, Adress, Password);
            User user = new User()
            {
                fName = FName,
                lName = LName,
                email = Email,
                adress = Adress,
                password = Password
            };
            users.Add(user);

        }

        public void AddAdmin( string FName, string LName, string Email, string Adress, string Password)
        {
            ud.AddAdministrator(FName, LName, Email, Adress, Password);
            User user = new User()
            {
                fName = FName,
                lName = LName,
                email = Email,
                adress = Adress,
                password = Password
            };
            users.Add(user);
        }

        public void RemoveUser(User u)
        {
            foreach (User user in users)
            {
                
                    users.Remove(u);
                    ud.DeleteUser(u);
                    return;
                
            }

        }

        public List<User> GetAllUsers()
        {
            
            return users;
        }
    }
}
