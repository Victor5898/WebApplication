using System;

namespace WebApplication.Domain
{
    public class ULoginData
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string LoginIp { get; set; }
        public DateTime LoginDataTime { get; set; }
    }
}
