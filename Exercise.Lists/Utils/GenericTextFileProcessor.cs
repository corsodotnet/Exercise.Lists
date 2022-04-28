using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Lists.Utils
{
    public static class GenericTextFileProcessor
    {
        public static List<T> LoadFromTextFile<T>(string filePath) where T : class, new()
        {
            T obj = new();
            var type = obj.GetType().GetProperties();


            // read all the lines from the file      
            // get and store the HEADERS to compare after
            // Get the TYPE of The OBJECT in Context -> COLS 
            // loop all the Lines fo teh File 
            // for each line :
            //     
            //      -> Compare the Object PROPERTY WITH THE COLUMN, if are the same, add VAL to PROPERTY
            //---->   [ COL.SetValue(entry, Convert.ChangeType(vals[i], col.PropertyType)); ]
            //ADD  the new object to the List to be Retuned 
            return null;
        }
        public static void SaveToTextFile<T>(List<T> data, string filePath) where T : class
        {
            List<string> lines = new List<string>();
            StringBuilder line = new StringBuilder();

            if (data == null || data.Count == 0)
            {
                throw new ArgumentNullException("data", "Devi popolare l'oggeto data con almeno una riga");
            }

            var cols = data[0].GetType().GetProperties(); // Estrai  tutte le properties dell'oggetto 

            foreach (var col in cols) // Per gni oggetto il nome dell property ---> HEADER
            {
                line.Append(col.Name);
                line.Append(",");
            }

            lines.Add(line.ToString().Substring(0, line.Length - 1));


            foreach (var row in data)
            {
                line = new StringBuilder(); // Clear dello stringBuilder

                foreach (var col in cols)// cicla properties
                {
                    line.Append(col.GetValue(row)); /// row  === Oggetto
                    line.Append(",");
                }

                lines.Add((line.ToString().Substring(line.Length - 1)));
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }
    }

}
