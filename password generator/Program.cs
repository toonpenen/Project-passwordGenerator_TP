using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Password(20);
            Console.WriteLine(password);
        }
        static string Password(int length)
        {
            string chars = "0123456789abcderfcdsdGTYJJKKLYEFGXGWEWE";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);

            }
            return sb.ToString();
        }
        
        
    }
}
