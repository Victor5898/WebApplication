using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Entities.Session;

namespace WebApplication.BusinessLogic.DbModel.Seed
{
    public class SessionContext: DbContext
    {
        public SessionContext() : base("name = WebApplication")
        {

        }

        public virtual DbSet<SessionDbTable> Sessions { get; set; }
    }
}
