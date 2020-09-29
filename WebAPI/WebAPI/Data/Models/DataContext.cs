using Microsoft.EntityFrameworkCore;
using Users.Data;

namespace WebAPI.Data.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceGroup> ServicesGroups { get; set; }

    }
}