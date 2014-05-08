using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
   static public  class Loops
    {
        public static string LoopSplit(string[] mealContent, int length,int ltimes)
        {
            int i;
            FileStream fs = new FileStream("../../Data/menu.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for (i = 0; i < length; i++)
            {
                if (i == 0) {
                    Console.WriteLine("* Lunch Menu*");
                    sw.WriteLine("* Lunch Menu*");
                }
                else if (i == ltimes)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("* Dinner Menu *");
                    sw.WriteLine(" ");
                    sw.WriteLine("* Dinner Menu *");
                }

                string[] mealSplit = mealContent[i].Split(',');
                //Console.WriteLine(mealContent[i] + "\t"); //after sorting in ascending order
                int mealLength = mealContent.Length;
                for (int j = i; j <= i; j++)
                {

                    for (int k = 0; k <= 3; k++)
                    {
                        // Console.WriteLine(mealSplit[k]);
                        for (int f = 0; f <= 0; f++)
                        {
                            if (mealSplit[k] == mealSplit[3])
                            {
                                
                                float price= float.Parse(mealSplit[3].Substring(1));
                                
                                TextWriter tmp = Console.Out;

                                Console.Write("$"+((price * 1.8).ToString("n2")) + " \t");

                                Console.Write(mealSplit[1] + ", " + mealSplit[2]);

                                sw.Write("$" + ((price * 1.8).ToString("n2")) + " \t");

                                sw.WriteLine(mealSplit[1] + ", " + mealSplit[2]);
                                     
                                
                                Console.WriteLine();

                               
                           
                            }
                        }
                    }
                   
                }
            }
            sw.Close(); 
            return "0";  
        }
    }
}

