using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem using REGEX and Pattern!");
            Console.WriteLine("User need to follow pre-defined Mobile Format!");
            string phoneNumber = @"^[0-9]{2}[ ][0-9]{10}$";

            Regex regex = new Regex(phoneNumber);
            Console.WriteLine("Enter Phone Number:");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}