using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic.Interface
{
    public interface IAdmin
    {
        List<UserMinimal> GetUsers();
    }
}
