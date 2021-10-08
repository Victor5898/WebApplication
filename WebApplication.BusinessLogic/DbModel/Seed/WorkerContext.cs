using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Entities.Staff;

namespace WebApplication.BusinessLogic.DbModel.Seed
{
    public class WorkerContext: DbContext
    {
        public WorkerContext() : base("name = WebApplication")
        {

        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }*/ 

        public virtual DbSet<WDbTable> Workers { get; set; }
    }
}
