using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Entities.Services;
using WebApplication.Domain.Entities.Staff;

namespace WebApplication.BusinessLogic.Interface
{
    public interface IService
    {
        List<Service> GetServices();
        List<Worker> GetStaff();
        Service GetSingleService(int id);
    }
}
