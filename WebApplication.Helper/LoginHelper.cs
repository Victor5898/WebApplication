using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WebApplication.Helper
{
    public class LoginHelper
    {
        public static string HashGen(string password)
        {
            MD5 md5alg = new MD5CryptoServiceProvider();
            var originPass = Encoding.Default.GetBytes(password + "randomString");
            var encodedPass = md5alg.ComputeHash(originPass);

            return BitConverter.ToString(encodedPass).Replace("-", "").ToLower();
        }
    }
}
