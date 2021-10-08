using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic.DbModel.Seed
{
    public class UserContext: DbContext
    {
        public UserContext() : base("name = WebApplication")
        {

        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
