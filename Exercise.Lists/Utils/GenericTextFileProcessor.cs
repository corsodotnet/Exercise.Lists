using System.Collections.Generic;

namespace Exercise.Lists.Utils
{
    public static class GenericTextFileProcessor
    {
        public static List<T> LoadFromTextFile<T>(string filePath) where T : class, new()
        {
            // read all the lines from the file      
            // get and store the HEADERS to compare after
            // Get the TYPE of The OBJECT in Context -> COLS 
            // loop all the Lines fo teh File 
            // for each line :
            //     
            //      -> Compare the Object PROPERTY WITH THE COLUMN, if are the same, add VAL to PROPERTY
            //      ->[ COL.SetValue(entry, Convert.ChangeType(vals[i], col.PropertyType)); ]
            //ADD  the new object to the List to be Retuned

        }
        public static void SaveToTextFile<T>(List<T> data, string filePath) where T : class
        {
        }
    }
