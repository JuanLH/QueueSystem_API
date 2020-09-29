using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Users.Data
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        void UpdateUser(int id, User user);
        void DeleteUser(int id);
        void AddUser(User user);

    }
}
