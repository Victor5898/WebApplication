using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebApplication.BusinessLogic.Core;
using WebApplication.BusinessLogic.Interface;
using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic
{
    public class SessionBL: UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }
        public HttpCookie GenCookie(string Credential)
        {
            return GenerateCookie(Credential);
        }

        public UserMinimal GetUserByCookie(string cookie)
        {
            return UserCookie(cookie);
        }
    }
}
