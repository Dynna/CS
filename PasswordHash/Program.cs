using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace PasswordHash
{
    class Program
    {
        static string password = "adminpass123";
        static string filePath = @"C:\Users\User\Desktop\password.txt";

        static void Main(string[] args)
        {
            string salt = CreateSalt(10);
            string hashed_password = GenerateSHA256Hash(password, salt);
            File.WriteAllText(filePath, hashed_password);

            Console.Title = "Login";
            Console.WriteLine("Hello, please input your password: ");
            string input_pass = Console.ReadLine();
            string hashed_input_pass = GenerateSHA256Hash(input_pass, salt);

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string extracted_pass = streamReader.ReadToEnd();

                if (hashed_input_pass == extracted_pass)
                {
                    Console.WriteLine("Welcome! You logged in succesfully.");
                }
                else
                {
                    Console.WriteLine("Wrong password! Login failed.");
                }
                
            }
            
             Console.Read(); 
        }

        static string CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        static string GenerateSHA256Hash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sha256hashstring = new SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }

        static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
