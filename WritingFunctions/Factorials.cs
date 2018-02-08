using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace WritingFunctions
{
    class Factorials
    {
        static int Factorial(int num)
        {
            if (num < 1)
            {
                return 0;
            }
            else if ( num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }


        public static void RunFactorial()
        {
            Write("Enter a number: ");
            if (int.TryParse(ReadLine(), out int number))
            {
                WriteLine(
                  $"{number:N0}! = {Factorial(number):N0}");
            }
            else
            {
                WriteLine("You did not enter a valid number!");
            }
        }
    }
}
