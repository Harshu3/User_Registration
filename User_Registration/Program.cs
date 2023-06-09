﻿using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem using REGEX and Pattern!");
            Console.WriteLine("User need to follow Pre-defined PassWord rules!");
            Console.WriteLine("[Rule 4] Has exactly 1 Special Character");
            string passWord = @"^(?=.*?[A-Za-z0-9][!@#$%^&*]).{8,}$";

            Regex regex = new Regex(passWord);
            Console.WriteLine("Enter PassWord:");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}