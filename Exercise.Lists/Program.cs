using Exercise.Lists.Models;
using System.Collections.Generic;

namespace Exercise.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {    // string path = "C:\temp\people.csv"


            // 1 -  SAVE a list o PEOPLE  from DataList to file csv
            // 2 -  Use the the same file to Load data from FILE to a List of PEOPLE 

            //foreach (var p in newPeople)
            //{
            //    Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            //}
        }
        private static void PopulateLists(List<Person> people)
        {
           
        }

        // Create a method to populate MockData
        static string MockData(List<Person> peoples)
        {
            char sep = ',';
            string data = "";
            foreach (Person people in peoples)
            {
                string id = people.ID.ToString();
                string name = people.Name;
                string isActive = people.IsActive.ToString();
                data += id + sep + name + sep + isActive + "\n";
            }
            return data;
        }
    }
}
