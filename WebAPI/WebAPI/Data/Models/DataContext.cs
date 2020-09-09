﻿using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
