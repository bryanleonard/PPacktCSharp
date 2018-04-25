using System;                     // DateTime
using System.Collections.Generic; // List<T>, HashSet<T>
using System.Xml.Serialization;   // XmlSerializer
using System.IO;                  // FileStream
using Packt.CS7;                  // Person
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace WorkingWithSerialization
{
    class Program
    {
        //https://www.packtpub.com/mapt/book/application_development/9781788398077/11/ch11lvl1sec78/serializing-object-graphs
        static void Main(string[] args)
        {
            // create an object graph 
            var people = new List<Person>
            {
                new Person(30000M) { FirstName = "Alice", LastName = "Smith", DateOfBirth = new DateTime(1974, 3, 14) },
                new Person(40000M) { FirstName = "Bob", LastName = "Jones", DateOfBirth = new DateTime(1969, 11, 23) },
                new Person(20000M) { FirstName = "Charlie", LastName = "Rose", DateOfBirth = new DateTime(1964, 5, 4),
                    Children = new HashSet<Person>
                    {
                        new Person(0M) {
                            FirstName = "Sally", LastName = "Rose",
                            DateOfBirth = new DateTime(1990, 7, 12)
                        }
                    }
                }
            };

            // create a file to write to 
            string path = Combine(CurrentDirectory, "people.xml");

            FileStream stream = File.Create(path);

            // create an object that will format as List of Persons as XML 
            var xs = new XmlSerializer(typeof(List<Person>));

            // serialize the object graph to the stream 
            xs.Serialize(stream, people);

            // you must close the stream to release the file lock 
            stream.Close();

            WriteLine($"Written {new FileInfo(path).Length} bytes of XML to 
   { path}
            "); 
   WriteLine();

            // Display the serialized object graph 
            WriteLine(File.ReadAllText(path));
        }
    }
}
