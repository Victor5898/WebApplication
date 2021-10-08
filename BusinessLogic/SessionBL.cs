using WebApplication.BusinessLogic.Core;
using WebApplication.BusinessLogic.Interfaces;
using WebApplication.Domain;
using System.Web;

namespace WebApplication.BusinessLogic
{
    public class SessionBL: UserAPI, ISession
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }

        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }

        /*public HttpCookie GenCookie(string Credential)
        {
            return GenerateCookie(Credential);
        }*/
    }
}
