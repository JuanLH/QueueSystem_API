using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
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

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChangesAsync();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault<User>();
            _context.Users.Remove(user);
            _context.SaveChangesAsync();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList<User>();
        }

        public User GetUserById(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault<User>();

            if (user != null)
            {
                return user;
            }
            else {
                return null;
            }
            
        }

        public void UpdateUser(int id, User user)
        {
            if (id != user.Id)
                return;

            
        }
    }
}
