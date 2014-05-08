using System;
using System.IO;

namespace FileIOManager
{
    static public class FileReader
    {
        private static int GetLineCount()
        {
            StreamReader sr = new StreamReader(FileLocation.INPUT_FILE);
            int counter     = 0;

            while (!sr.EndOfStream){
                counter++;
                sr.ReadLine();
            }
            sr.Close();
            return counter;
        }

        public static string[] ReadLines()
        {
            int      totalItems  = GetLineCount();
            string[] itemDetails = new string[totalItems];
            StreamReader      sr = new StreamReader(FileLocation.INPUT_FILE);

            string itemDetail;
            int counter = 0;

            while (!sr.EndOfStream)
            {
                itemDetail = sr.ReadLine();
                if (itemDetail.Trim() != "")
                    itemDetails[counter++] = itemDetail;
            }
            
            sr.Close();
            return itemDetails;
        }
    }
}
