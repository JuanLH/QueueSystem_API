using System.Collections.Generic;
using WebAPI.Data.Models;

namespace Services.Data
{
    public interface IServiceService
    {
        List<Service> GetAllService();
        Service GetServiceById(int id);
        Service UpdateService(Service user);
        Service DeleteService(int id);
        Service AddService(Service user);
    }
}
