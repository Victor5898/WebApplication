using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.BusinessLogic.Core;
using WebApplication.BusinessLogic.Interface;
using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic
{
    class AdminBL: UserApi, IAdmin
    {
        public List<UserMinimal> GetUsers()
        {
            return GetUsersAdmin();
        }
    }
}
