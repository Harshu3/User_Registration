using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem using REGEX and Pattern!");
            Console.WriteLine("User need to follow Pre-defined PassWord rules!");
            Console.WriteLine("[Rule 2] Should have at least 1 Upper Case");
            string passWord = @"^(?=.*?[A-Za-z]).{8,}$";

            Regex regex = new Regex(passWord);
            Console.WriteLine("Enter PassWord:");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}