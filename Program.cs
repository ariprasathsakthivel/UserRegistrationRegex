using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your First name to check");
            //string firstName = Console.ReadLine();
            //Console.WriteLine(NameCheck(firstName));
            //Console.WriteLine("Enter your First name to check");
            //string lastName = Console.ReadLine();
            //Console.WriteLine(NameCheck(lastName));
            Console.WriteLine("Enter your Email ID");
            string eMail = Console.ReadLine();
            Console.WriteLine(EmailCheck(eMail));
        }
        public static bool NameCheck(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return Regex.IsMatch(name, pattern);
        }
        public static bool EmailCheck(string eMail)
        {
            string pattern = "^[a-z]{2,}[.]?[a-z    ]*[@][a-z]{2,}[.][a-z]{2,3}([.]{0,1}[a-z]{0,2})?";
            return Regex.IsMatch(eMail, pattern);
        }
    }
}
