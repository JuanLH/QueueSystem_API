using System.Collections.Generic;
using System.Linq;
using WebAPI.Data.Models;

namespace Services.Data
{
    public class ServiceService : IServiceService
    {
        private readonly DataContext _context;

        public ServiceService(DataContext context)
        {
            _context = context;
        }

        public Service AddService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return service;
        }

        public Service DeleteService(int id)
        {
            var service = _context.Services.Where(u => u.Id == id).FirstOrDefault<Service>();
            _context.Services.Remove(service);
            _context.SaveChanges();
            return service;
        }

        public List<Service> GetAllServices()
        {
            return _context.Services.ToList<Service>();
        }

        public Service GetServiceById(int id)
        {
            var service = _context.Services.Where(s => s.Id == id).Single<Service>();

            if (service != null)
            {
                return service;
            }
            else
            {
                return null;
            }
        }

        public Service UpdateService(Service service)
        {
            Service ser = _context.Services.Where(s => s.Id == service.Id).Single<Service>();
            _context.Entry(ser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return ser;
        }
    }
}
