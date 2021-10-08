using System.Web;
using System.Web.Mvc;
using WebApplication.BusinessLogic;
using WebApplication.BusinessLogic.Interface;
using WebApplication.Domain.Entities.User;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ISession _session;
        public HomeController()
        {
            BussinesLogic bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        // GET: Home
        public ActionResult Index()
        {
            UserMinimal userMin = new UserMinimal();
            userData user = new userData();
            HttpCookie CookieApi = System.Web.HttpContext.Current.Request.Cookies["X-KEY"];
            if (CookieApi != null)
            {
                userMin = _session.GetUserByCookie(CookieApi.Value);
            }
            if (userMin == null)
            {
                user.Username = "Username";
            }
            else
            {
                user.Username = userMin.Username;
            }

            return View(user);
        }
    }
}