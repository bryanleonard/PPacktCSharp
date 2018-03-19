using System;
using System.Collections.Generic;
using static System.Console;
using System.Collections.Immutable;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string> { "London", "Paris", "Milan", "Akron", "New York" };
            //instead of 
            //var cities = new List<string>();
            //cities.Add("London");

            WriteLine("Initial list:");
            foreach (string city in cities)
            {
                WriteLine($"  {city}");
            }

            WriteLine($"The first city is {cities[0]}.");
            WriteLine($"The last city is {cities[cities.Count - 1]}.");
            cities.Insert(0, "Sydney");
            WriteLine("After inserting Sydney at index 0");
            foreach (string city in cities)
            {
                WriteLine($"  {city}");
            }

            cities.RemoveAt(1);
            cities.Remove("Milan");
            WriteLine("After removing two cities");
            foreach (string city in cities)
            {
                WriteLine($"  {city}");
            }

            var immutableCities = cities.ToImmutableList();

            var newList = immutableCities.Add("Rio"); //does't work bc immutable :)

            WriteLine("\nImmutable cities:");
            foreach (string city in immutableCities)
            {
                WriteLine($" {city}");
            }
            WriteLine();

            WriteLine("New cities:");
            foreach (string city in newList)
            {
                WriteLine($" {city}");
            }
            WriteLine();
        }
    }
}
