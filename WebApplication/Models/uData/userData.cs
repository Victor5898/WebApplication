using System.Collections.Generic;
using WebApplication.Domain.Entities.Services;
using WebApplication.Domain.Entities.Staff;
using WebApplication.Domain.Entities.User;
using WebApplication.Models.uData;

namespace WebApplication.Models
{
    public class userData
    {
        public string Username { get; set; }
        public List<Slider> slide { get; set; }
        public List<Service> services { get; set; }
        public List<userWorkers> staff { get; set; }
        public Service service { get; set; }
        public List<Service> lastServices { get; set; }
        public List<UserMinimal> users { get; set; }
    }
}