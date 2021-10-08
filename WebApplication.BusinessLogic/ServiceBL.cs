using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BusinessLogic.Core;
using WebApplication.BusinessLogic.Interface;
using WebApplication.Domain.Entities.Services;
using WebApplication.Domain.Entities.Staff;

namespace WebApplication.BusinessLogic
{
    public class ServiceBL: UserApi, IService
    {
        public List<Service> GetServices()
        {
            return GetServicesAction();
        }

        public List<Worker> GetStaff()
        {
            return GetStaffAction();
        }

        public Service GetSingleService(int id)
        {
            return GetSingleServiceAction(id);
        }
    }
}
