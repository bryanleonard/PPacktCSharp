using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> valList = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                valList.Add(setResult(i));
            }

            valList.ForEach(i => Console.Write($"{i}, "));
            //Console.WriteLine();

            //Or 
            //for (int n = 1; n <= 100; n++)
            //{
            //    if (n % 15 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (n % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (n % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(n);
            //    }
            //}
            //Or
            //for (int i = 1; i <= 100; i++)
            //{
            //    bool fizz = i % 3 == 0;
            //    bool buzz = i % 5 == 0;
            //    if (fizz && buzz)
            //        Console.WriteLine("FizzBuzz");
            //    else if (fizz)
            //        Console.WriteLine("Fizz");
            //    else if (buzz)
            //        Console.WriteLine("Buzz");
            //    else
            //        Console.WriteLine(i);
            //}
        }

        public static string setResult(int curVal)
        {
            string result = null;

            if (curVal % 3 == 0 && curVal % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if (curVal % 3 == 0)
            {
                result = "Fizz";
            }
            else if (curVal % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = curVal.ToString();
            }
            return result;
        }
    }
}
