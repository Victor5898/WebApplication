using WebApplication.Domain;
using System.Web;

namespace WebApplication.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        //HttpCookie GenCookie(string Credential);
    }
}
