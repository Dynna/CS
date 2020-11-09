using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordApp
{
    class CodeGenerator
    {
        // Function that generates random password which might consist of Uppercase/Lowercase characters and/or Digits
        public static string CreateCode(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder result = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                result.Append(valid[rnd.Next(valid.Length)]);
            }
            return result.ToString();
        }
    }
}
