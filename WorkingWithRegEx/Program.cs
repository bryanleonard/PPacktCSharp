using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace WorkingWithRegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age: ");
            string input = ReadLine();
            //var ageChecker = new Regex(@"\d"); //Enter any characters you want as long as you enter at least one digit character.
            var ageChecker = new Regex(@"^\d$");
            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"This is not a valid age: {input}");
            }
        }
    }
}
