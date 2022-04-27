using Exercise.Lists.Models;
using Exercise.Lists.Utils;
using System;
using System.Collections.Generic;

namespace Exercise.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\Temp\people.csv";
            string logFile = @"C:\Temp\logs.csv";

            PopulateLists(people);
            OriginalTextFileProcessor.SavePeople(people, peopleFile);

            var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            }
        }
        private static void PopulateLists(List<Person> people)
        {
            people.Add(new Person { FirstName = "Bruno", LastName = "Corey" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", IsAlive = false });
            people.Add(new Person { FirstName = "Greg", LastName = "Olsen" });


        }

        // Create a method to populate MockData
    }
}
