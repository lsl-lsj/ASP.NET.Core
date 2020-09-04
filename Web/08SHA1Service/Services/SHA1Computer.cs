using System;
using System.Security.Cryptography;
using System.Text;
namespace _08SHA1Service
{
    public class SHA1Computer
    {
        public string Compute(string input)
        {
            byte[] data = Encoding.UTF8.GetBytes(input);
            byte[] res = null;
            using (SHA1 sh = SHA1.Create())
            {
                res = sh.ComputeHash(data);
            }
            return Convert.ToBase64String(res);
        }
    }
}