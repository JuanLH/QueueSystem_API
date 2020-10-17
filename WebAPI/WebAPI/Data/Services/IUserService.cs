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
        User UpdateUser(User user);
        User DeleteUser(int id);
        User AddUser(User user);

    }
}
