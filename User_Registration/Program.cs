using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem using REGEX and Pattern!");
            Console.WriteLine("Valid User Email ID!");
            string email = @"[a-z]{3,}.?[a-z0-9]{3,}[@][a-z]{2,}.(com|org)$";

            Regex regex = new Regex(email);
            Console.WriteLine("Enter Email ID:");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}