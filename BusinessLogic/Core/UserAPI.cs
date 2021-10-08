using WebApplication.Domain;
using System.Web;

namespace WebApplication.BusinessLogic.Core
{
    public class UserAPI
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            return new ULoginResp();
        }

        /*internal HttpCookie GenerateCookie(string Credential)
        {
            return new HttpCookie();
        }*/
    }
}
