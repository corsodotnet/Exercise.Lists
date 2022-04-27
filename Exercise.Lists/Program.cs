using Exercise.Lists.Models;
using Exercise.Lists.Utils;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 -  SAVE a list o PEOPLE from DataList to file csv
            // 2 -  Use the the same file to Load data from FILE to a List of PEOPLE 


            // 3 -  Print out all the PEOPLE properties from file 

            // use a utility class to create STANDARD METHODS to manager both situation !!
            // USE FILE STATIC FILE PATH !!!
            // USE FILE STATIC FILE PATH !!!

            char s = Path.DirectorySeparatorChar;
            string pathFolder = $"C:{s}Temp";
            string pathFile = $"C:{s}Temp{s}people.csv";

            List<People> peoples = new List<People>()
            {
                new People(1, "Bruno", true),
                new People(2, "Luca", false),
                new People(3, "Giorgio", true)
            };
            string data = MockData(peoples);
            OriginalTextFileProcessor.ComposeFile(pathFile, pathFolder, data);
            OriginalTextFileProcessor.ReadFile(pathFile);
        }

        // Create a method to populate MockData
        static string MockData(List<People> peoples)
        {
            char sep = ',';
            string data = "";
            foreach(People people in peoples)
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
