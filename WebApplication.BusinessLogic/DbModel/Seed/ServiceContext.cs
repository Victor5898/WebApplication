using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Entities.Services;

namespace WebApplication.BusinessLogic.DbModel.Seed
{
    public class ServiceContext: DbContext
    {
        public ServiceContext() : base("name = WebApplication")
        {

        }

        public virtual DbSet<SDbTable> Services { get; set; }
    }
}
