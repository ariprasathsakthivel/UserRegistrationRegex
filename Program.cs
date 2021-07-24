using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name to check");
            string name = Console.ReadLine();
            Console.WriteLine(PatternCheck(name));
        }
        public static bool PatternCheck(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return Regex.IsMatch(name, pattern);
        }
    }
}
