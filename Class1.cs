using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashPassword1
{

    public class Class1
    {
        public static string getHashedPassword(string passwd)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] sourceBytePasswd = Encoding.UTF8.GetBytes(passwd);
                byte[] hashSourceBytePasswd = sha256.ComputeHash(sourceBytePasswd);
                string hashPasswd = BitConverter.ToString(hashSourceBytePasswd).Replace("-", String.Empty);
                return hashPasswd;
            }
        }
    }
}
