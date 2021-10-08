using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Domain.Enums;

namespace WebApplication.Models
{
    public class adminData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        //--------------------------------------------
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime lastLogin { get; set; }
        public string UserIp { get; set; }
        public URole Level { get; set; }

        //---------------------------------------------
        /*public string WorkerName { get; set; }
        public string WorkerImage { get; set; }*/
    }
}