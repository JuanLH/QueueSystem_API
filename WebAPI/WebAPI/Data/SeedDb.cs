using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data.Models;

namespace WebAPI.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckUserAsync();
        }

        private async Task CheckUserAsync()
        {
            if (!_context.Users.Any()) {
                _context.Users.Add(new Users.Data.User
                {
                    UserName = "JuanLH",
                    Password ="letmein",
                    FirstName="Juan",
                    LastName="Hiciano",
                    IdCard="402-2439183-5",
                    IdCardType = Utils.Enums.CardTypeEnum.Cedula,
                    Dob=DateTime.Now,
                    CellPhone = "829-787-8578"
                });

                _context.Users.Add(new Users.Data.User
                {
                    UserName = "EmilyS",
                    Password = "letmein",
                    FirstName = "Emily",
                    LastName = "Sanchez",
                    IdCard = "402-2539183-1",
                    IdCardType = Utils.Enums.CardTypeEnum.Cedula,
                    Dob = DateTime.Now,
                    CellPhone = "809-874-2509"
                });
                await _context.SaveChangesAsync();
            }
        }
    }
}
