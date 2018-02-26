using System;
using static System.Console;
using Packt.CS7; //PacktLibrary
using System.Collections.Generic;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            



            WriteLine("*********************************");

            Employee aliceInEmployee = new Employee { Name = "Alice Pooper", EmployeeCode = "AA123" };


`
            Person aliceInPerson = aliceInEmployee;
                aliceInEmployee.WriteToConsole();
                aliceInPerson.WriteToConsole();

            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());



            //Employee e2 = (Employee)aliceInPerson;

            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee\n");
                Employee e2 = (Employee)aliceInPerson;
                // do something with e2
            }

            Employee e3 = aliceInPerson as Employee;
            if (e3 != null)
            {
                WriteLine($"{nameof(aliceInPerson)} AS an Employee\n");
                // do something with e3 
            }

            WriteLine("*********************************");

            Employee e1 = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28)
            };
            e1.WriteToConsole();

            e1.EmployeeCode = "JJ001";
            e1.HireDate = new DateTime(2014, 11, 23);
            WriteLine($"{e1.Name} was hired on {e1.HireDate:MM/dd/yy}");

            WriteLine(e1.ToString());



            WriteLine("*********************************");

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X},{dv3.Y})");

            WriteLine("*********************************");

            string number1 = "4";
            WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");

            byte number2 = 3;
            WriteLine($"{number2} squared is {Squarer.Square<byte>(number2)}");

            WriteLine("*********************************");

            var gt = new GenericThing<int>();
            gt.Data = 42;
            WriteLine($"GenericThing: {gt.Process("42")}");

            //var t = new Thing();
            //t.Data = 42;
            //WriteLine($"\nThing: {t.Process("42")}"); // doesn't work, there's no type comparison safety

            WriteLine("*********************************");

            //Person[] people =
            //{
            //   new Person { Name = "Simon" },
            //   new Person { Name = "Ben"},
            //   new Person { Name = "Jenny" },
            //   new Person { Name = "Adam" },
            //   new Person { Name = "Richard" }
            //};

            ////WriteLine("Initial list of people");
            ////foreach (var p in people)
            ////{
            ////    WriteLine($"{p.Name}");
            ////}

            //WriteLine("\nUse Person's IComparable implementation to sort:");
            //Array.Sort(people);
            //foreach (var person in people)
            //{
            //    Write($"{person.Name} ");
            //}

            //WriteLine("\nUse PersonComparer's IComparer implementation to sort:");
            //Array.Sort(people, new PersonComparer());
            //foreach (var person in people)
            //{
            //    Write($"{person.Name} ");
            //}

            //WriteLine("\n*********************************");

            //var harry = new Person { Name = "Harry" };
            //var mary = new Person { Name = "Mary" };
            //var jill = new Person { Name = "Jill" };

            //// call instance method 
            //var baby1 = mary.ProcreateWith(harry);

            //// call static method
            //var baby2 = Person.Procreate(harry, jill);

            //// call an operator
            //var baby3 = harry * mary;

            //WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            //WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            //WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            //WriteLine($"{mary.Name}'s first child is named \"{mary.Children[0].Name}\".");

            //WriteLine("*********************************");
            //WriteLine($"5! is {Person.Factorial(5)}");
            //WriteLine("*********************************");

            //harry.Shout += Harry_Shout;
            //harry.Poke();
            //harry.Poke();
            //harry.Poke();
            //harry.Poke();

            // Prior to Chapter 6

            //var sam = new Person
            //{
            //    Name = "Sam",
            //    DOB = new DateTime(1972, 1, 27)
            //};
            //WriteLine(sam.Origin);
            //WriteLine(sam.Greeting);
            //WriteLine(sam.Age);

            //WriteLine("*********************************");

            //sam.Children.Add(new Person { Name = "Charlie" });
            //sam.Children.Add(new Person { Name = "Ella" });
            //WriteLine($"Sam's first child is {sam.Children[0].Name}");
            //WriteLine($"Sam's second child is {sam.Children[1].Name}");
            //WriteLine($"Sam's first child is {sam[0].Name}");
            //WriteLine($"Sam's second child is {sam[1].Name}");

            //WriteLine("*********************************");

            //sam.FaveIceCream = "Chocolate Fudge";
            //WriteLine($"Sam's favorite ice-cream flavor is  {sam.FaveIceCream}.");
            //sam.FavePrimaryColor = "Red";
            //WriteLine($"Sam's favorite primary color is  {sam.FavePrimaryColor}.");

            //WriteLine("*********************************");

            //var p1 = new Person();
            //p1.Name = "Bob Smith";
            //p1.DOB = new System.DateTime(1965, 12, 22);
            //p1.FavHobby = "Lute";
            //WriteLine($"{p1.Name} was born on {p1.DOB:dddd, d MMMM  yyyy}. Favorite hobby is {p1.FavHobby}.");
            //p1.FavouriteAncientWonder =
            //    WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            //WriteLine($"{p1.Name}'s favourite wonder is {p1.FavouriteAncientWonder}");

            //p1.Children.Add(new Person { Name = "Alfred" });
            //p1.Children.Add(new Person { Name = "Zoe" });
            //WriteLine($"{p1.Name} has {p1.Children.Count} children:");
            //for (int child = 0; child < p1.Children.Count; child++)
            //{
            //    WriteLine($"  {p1.Children[child].Name}");
            //}

            //WriteLine($"{p1.Name} is a {Person.Species}");
            //WriteLine($"{p1.Name} was born on {p1.HomePlanet}"); // readonly preferrable to const, I guess.

            //WriteLine("*********************************");

            //int a = 10;
            //int b = 20;
            //int c = 30;
            //WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            //p1.PassingParameters(a, ref b, out c);
            //WriteLine($"After: a = {a}, b = {b}, c = {c}");

            //WriteLine("*********************************");

            //// simplified C# 7 syntax for out parameters
            //int d = 10;
            //int e = 20;
            //WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
            //p1.PassingParameters(d, ref e, out int f);
            //WriteLine($"After: d = {d}, e = {e}, f = {f}");

            ////WriteLine("*********************************");

            ////var p3 = new Person();
            ////WriteLine($"{p3.Name} was instantiated at {p3.Instantiated:hh:mm:ss} on { p3.Instantiated:dddd, d MMMM yyyy}");

            ////WriteLine("*********************************");

            ////var p4 = new Person("Aziz");
            ////WriteLine($"{p4.Name} was instantiated at { p4.Instantiated:hh: mm: ss} on { p4.Instantiated:dddd, d MMMM yyyy}");

            ////WriteLine("*********************************");

            ////p1.WriteToConsole();
            ////WriteLine(p1.GetOrigin());

            ////WriteLine("*********************************");
            ////WriteLine(p1.OptionalParameters());

            ////WriteLine("*********************************");

            ////Tuple<string, int> fruit4 = p1.GetFruitCS4();
            ////WriteLine($"There are {fruit4.Item2} {fruit4.Item1}.");

            ////(string, int) fruit7 = p1.GetFruitCS7();
            ////WriteLine($"{fruit7.Item1}, {fruit7.Item2} there are.");

            ////var fruitNamed = p1.GetNamedFruit();
            ////WriteLine($"Are there {fruitNamed.Number} {fruitNamed.Name}?");

            ////WriteLine("*********************************");

            //////var p2 = new Person
            //////{
            //////    Name = "Alice Jones",
            //////    DOB = new DateTime(1998, 3, 17),
            //////    FavHobby = "Piano"
            //////};
            //////WriteLine($"{p2.Name} was born on {p2.DOB:dddd, d MMMM  yyyy}. Favorite hobby is {p2.FavHobby}.");

            ////WriteLine("*********************************");

            ////BankAccount.InterestRate = 0.012M;

            ////var ba1 = new BankAccount();
            ////ba1.AccountName = "Mrs. Jones";
            ////ba1.Balance = 2400;
            ////WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} interest.");

            ////var ba2 = new BankAccount();
            ////ba2.AccountName = "Ms. Gerrier"; 
            ////ba2.Balance = 98;

            ////WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest.");


        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }
    }
}
