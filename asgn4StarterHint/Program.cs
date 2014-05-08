using System;
using bubble; 
using FileIOManager;
using System.IO;
namespace Assignment3_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] mealContent = FileReader.ReadLines();
            int length = mealContent.Length ;

            mealContent=      Bubble.bubblesort(mealContent,length);
            int ltimes = 0;
            for (int i = 0; i < mealContent.Length; i++)
             {
                  
                 if (mealContent[i][0] == 'l') { 
                 
                 ltimes++; 
                 }
             }
            
             mealContent = Bubble.bubblesort2(mealContent,0, length   );
             mealContent = Bubble.bubblesort2(mealContent,ltimes-1 , length -ltimes );
             Loops.LoopSplit(mealContent, length,ltimes ); 
            
           
                  
                        Console.ReadLine();

                
       }
    }
 }
           
    