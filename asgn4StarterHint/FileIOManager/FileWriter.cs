using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOManager
{
    class FileWriter
    {
       public static void  WriteFile(){
        const string FILE_NAME = "log.txt"; 
        const bool APPEND = true; 
        const string MESSAGE = "Here is some log data."; 
        string  filePath;
           filePath = "../../Data" + FILE_NAME; 
        StreamWriter sw = new StreamWriter(filePath, APPEND); 
        // Create writer.// Append to file
        sw.WriteLine(MESSAGE);
         sw.Close(); 
     }
    }
}
