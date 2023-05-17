using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem using REGEX and Pattern!");
            Console.WriteLine("Valid User Last Name!");
            string name = "[A-Z][a-z]{3,}[ ][A-Z][a-z]{3,}";

            Regex regex = new Regex(name);
            Console.WriteLine("Enter first and last name:");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}