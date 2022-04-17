using System;
using System.Collections.Generic;
using System.Text;

namespace Modules
{
    public interface IUserDataManagement<User>
    {
        void AddUser(User entity);
        void AddAdministrator(User entity);

        User ReadUser(string email, string password);

        void DeleteUser(User entity);

        List<User> GetAllUsers();

        void EditUser(User entity);
    }
}
