using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BusinessLogic.Interface;

namespace WebApplication.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }

        public IService GetServiceBL()
        {
            return new ServiceBL();
        }

        public IAdmin GetAdminBL()
        {
            return new AdminBL();
        }
    }
}
