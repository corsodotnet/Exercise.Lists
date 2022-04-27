using Exercise.Lists.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise.Lists.Utils
{
    public static class OriginalTextFileProcessor
    {
        // load() PEOPLE objets from  FILE   
        // --> extract lines from file  
        // -> create a List of objects from each column 
        // -> each object must have PROPERTIES VALUES that match with each FILE COLUMN

        // Save() people FILE from objects
        // Save() people FILE from objects 


        public static void ComposeFile(string pathFile, string pathFolder, string data)
        {
            CheckCreateFolder(pathFolder);
            File.WriteAllText(pathFile, data);
        }

        public static void CheckCreateFolder(string path)
        {
            DirectoryInfo folder = new DirectoryInfo(path);
            if (!folder.Exists)
            {
                folder.Create();
            }
        }
        public static void ReadFile(string path)
        {
            List<People> list = new List<People>();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        int id = int.Parse(values[0]);
                        string name = values[1];
                        bool isActive = bool.Parse(values[2]);
                        list.Add(new People(id, name, isActive));
                    }
                }
                foreach (People people in list)
                {
                    Console.WriteLine($"ID: {people.ID} Nome: {people.Name} Attivo: {people.IsActive}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex);
            }
        }
    }
}
