using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First name to check");
            string firstName = Console.ReadLine();
            Console.WriteLine(NameCheck(firstName));
            Console.WriteLine("Enter your First name to check");
            string lastName = Console.ReadLine();
            Console.WriteLine(NameCheck(lastName));
        }
        public static bool NameCheck(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return Regex.IsMatch(name, pattern);
        }
    }
}
