using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For checking the first name
            Console.WriteLine("Enter your First name to check");
            string firstName = Console.ReadLine();
            Console.WriteLine(NameCheck(firstName));
            #endregion

            #region For checking Last Name
            Console.WriteLine("Enter your Last name to check");
            string lastName = Console.ReadLine();
            Console.WriteLine(NameCheck(lastName));
            #endregion

            #region For checking mail using testcases added
            string[] testMails = new string[]
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc@1.com",
                "abc@gmail.com.com",
                "abc+100@gmail.com"
            };
            foreach (string mail in testMails)
            {
                Console.WriteLine("{0}-->{1}", mail, EmailCheck(mail));
            }
            #endregion

            #region For checking the Phone number
            Console.WriteLine("Enter your Phone number to check");
            string number = Console.ReadLine();
            Console.WriteLine(PhoneNumberCheck(number));
            #endregion

            #region For checking the password
            Console.WriteLine("Enter the password to check");
            string password = Console.ReadLine();
            Console.WriteLine(PasswordCheck(password));
            #endregion
        }
        public static bool NameCheck(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return Regex.IsMatch(name, pattern);
        }
        public static bool EmailCheck(string eMail)
        {
            string pattern = "^[a-z]{2,}[-.+]?[a-z]*[0-9]*[@][a-z]*[0-9]*[.][a-z]{2,3}[.]{0,1}[a-z]{0,3}$";
            return Regex.IsMatch(eMail, pattern);
        }
        public static bool PhoneNumberCheck(string number)
        {
            string pattern = "^[9][1][ ][6-9][0-9]{9}$";
            return Regex.IsMatch(number, pattern);
        }
        public static bool PasswordCheck(string password)
        {
            string pattern = "^.*[!@#$%^&*,.-_][0-9]*$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
