using System.Collections.Generic;
using System.Linq;
using WebAPI.Data.Models;

namespace Users.Data
{
    public class UserService : IUserService
    {

        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public User AddUser(User user)
        {

            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User DeleteUser(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault<User>();
            _context.Users.Remove(user);
            _context.SaveChangesAsync();
            return user;

        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList<User>();
        }

        public User GetUserById(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).Single<User>();

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }

        }

        public User UpdateUser(User user)
        {
            User us = _context.Users.Where(u => u.Id == user.Id).Single<User>();
            _context.Entry(us).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return us;
        }

    }
}
