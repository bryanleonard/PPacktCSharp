using System;
using static System.Console;
using static System.Convert;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("before parsing");
            Write("What is your age? ");

            string input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                WriteLine($"you're {age} old.");
            }

            catch (OverflowException)
            {
                WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch (FormatException)
            {
                WriteLine("The age you entered is not a valid number format.");
            }

            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("done parsing");
        }
    }
}
