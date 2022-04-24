using System;
using System.Collections.Generic;
using System.Text;

namespace Modules
{
    public interface IUserDataManagement<User>
    {
        void AddUser(User entity);


        void DeleteUser(User entity);

        User GetUser(int id); // mainly used in OrderDataClass

        List<User> GetAllUsers();

        void EditUser(User entity);
    }
}
