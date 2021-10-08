using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic.Interface
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        HttpCookie GenCookie(string Credential);
        UserMinimal GetUserByCookie(string cookie);
    }
}
