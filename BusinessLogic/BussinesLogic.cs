using WebApplication.BusinessLogic.Interfaces;

namespace WebApplication.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
