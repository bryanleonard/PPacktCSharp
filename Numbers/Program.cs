using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to { int.MaxValue:N0}."); 
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} to { double.MaxValue:N0}."); 
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range { decimal.MinValue:N0} to { decimal.MaxValue:N0}.");

            Console.WriteLine("*********************");

            double a = 0.1;
            double b = 0.2;

            if (a+b == 0.3)
            {
                Console.WriteLine($"{a} + {b} (as doubles) equals 0.3");
            }
            else
            {
                //The double type is not guaranteed to be accurate. 
                //Only use double when accuracy, especially when comparing two numbers, ex. when measuring a person's height
                Console.WriteLine($"{a} + {b} (as doubles) does NOT equal 0.3");
            }

            Console.WriteLine("*********************");

            decimal c = 0.1M; // M indicates a decimal literal value
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} (as decimals) equals 0.3"); // winner, winner
            }
            else
            {
                Console.WriteLine($"{c} + {d} (as decimals) does NOT equal 0.3");
            }

            //Good Practice Use int for whole numbers and double for real numbers. 
            //Use decimal for money, CAD drawings, general engineering, and wherever accuracy of a real number is important.
        }
    }
}
