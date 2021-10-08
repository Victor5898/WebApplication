using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Domain.Enums;

namespace WebApplication.Models.uData
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime lastLogin { get; set; }
        public string UserIp { get; set; }
        public URole Level { get; set; }
    }
}