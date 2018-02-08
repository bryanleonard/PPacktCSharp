using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace WritingFunctions
{
    public class Logic
    {
        public static void TimesTable(byte num)
        {
            WriteLine($"This is the {num} times table");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {num} = {row * num}");
            }
        }

        public static void RunTimesTable()
        {
            Write("Enter a number between 0 and 255: ");
            if (byte.TryParse(ReadLine(), out byte num))
            {
                TimesTable(num);
            }
            else
            {
                WriteLine("You did not enter a valid number!");
            }
        }

        public static void RunSalesTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = SalesTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
                WriteLine($"Your total would be {amount + taxToPay}.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }

        public static decimal SalesTax(decimal amt, string regionCode)
        {
            decimal rate = 0.0M;

            switch (regionCode)
            {
                case "CH": // Switzerland
                    rate = 0.08M;
                    break;
                case "DK": // Denmark
                case "NO": // Norway
                    rate = 0.25M;
                    break;
                case "GB": // United Kingdom
                case "FR": // France
                    rate = 0.2M;
                    break;
                case "HU": // Hungary
                    rate = 0.27M;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0M;
                    break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                case "CA": // California
                    rate = 0.0825M;
                    break;
                default: // most US states
                    rate = 0.06M;
                    break;
            }
            return amt * rate;
        }




        static string CardinalToOrdinal(int number)
        {

            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    string numberAsText = number.ToString();
                    char lastDigit =
                        numberAsText[numberAsText.Length - 1];
                    string suffix = string.Empty;
                    switch (lastDigit)
                    {
                        case '1':
                            suffix = "st";
                            break;
                        case '2':
                            suffix = "nd";
                            break;
                        case '3':
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }
                return $"{number}{suffix}";
            }
        }

        public static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
        }

    }
}
