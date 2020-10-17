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

        public User AddUser(User user)
        {

            User us = new User();
            us.UserName = user.UserName;
            us.Password = user.Password;
            us.FirstName = user.FirstName;
            us.LastName = user.LastName;
            us.NickName = user.NickName;
            us.IdCard = user.IdCard;
            us.IdCardType = user.IdCardType;
            us.Dob = user.Dob;
            us.Telephone = user.Telephone;
            us.CellPhone = user.CellPhone;
            //us.CreateDate = user.CreateDate;
            us.UpdateDate = user.UpdateDate;
        
            _context.Users.Add(us);
            _context.SaveChanges();
            return us;
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
            else {
                return null;
            }
            
        }

        public User UpdateUser(User user)
        {
            User us = _context.Users.Where(u => u.Id == user.Id).Single<User>();
            us.UserName = user.UserName;
            us.Password = user.Password;
            us.FirstName = user.FirstName;
            us.LastName = user.LastName;
            us.NickName = user.NickName;
            us.IdCard = user.IdCard;
            us.IdCardType = user.IdCardType;
            us.Dob = user.Dob;
            us.Telephone = user.Telephone;
            us.CellPhone = user.CellPhone;
            //us.CreateDate = user.CreateDate;
            us.UpdateDate = user.UpdateDate;
            _context.Entry(us).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return us;
        }

    }
}
