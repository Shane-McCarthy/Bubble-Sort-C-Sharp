using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
   static public  class Bubble
    {
        ///bubble sort

       public  static string[] bubblesort(string[] dataset, int n)
        {
            int i, j;
            string bubbleArray = dataset[0];
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j].CompareTo(dataset[j - 1]) > 0)
                    {
                        bubbleArray = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = bubbleArray;
                    }
            return dataset; 
        }
       public static string[] bubblesort2(string[] dataset,int i, int n)
       {
           int  j;
           string bubbleArray = dataset[0];
           for (i = 0; i < n; i++)
               for (j = n - 1; j > i; j--)
                   if (dataset [j][0] == 'l'&&dataset [j-1][0]=='l' ){
                       if (dataset[j].Substring(6).CompareTo(dataset[j - 1].Substring(6)) < 0)
                       {
                           bubbleArray = dataset[j];
                           dataset[j] = dataset[j - 1];
                           dataset[j - 1] = bubbleArray;
                       }
                   }
                   else if (dataset[j][0] == 'l' && dataset[j - 1][0] == 'd')
                   {
                       if (dataset[j].Substring(6).CompareTo(dataset[j - 1].Substring(7)) < 0)
                       {
                           bubbleArray = dataset[j];
                           dataset[j] = dataset[j - 1];
                           dataset[j - 1] = bubbleArray;
                       }
                   }
           else if (dataset[j][0] == 'd' && dataset[j - 1][0] == 'l')
           {
               if (dataset[j].Substring(7).CompareTo(dataset[j - 1].Substring(6)) < 0)
               {
                   bubbleArray = dataset[j];
                   dataset[j] = dataset[j - 1];
                   dataset[j - 1] = bubbleArray;
               }
           } else if (dataset[j][0] == 'd' && dataset[j - 1][0] == 'd')
           {
               if (dataset[j].Substring(7).CompareTo(dataset[j - 1].Substring(7)) < 0)
               {
                   bubbleArray = dataset[j];
                   dataset[j] = dataset[j - 1];
                   dataset[j - 1] = bubbleArray;
               }
           }
           return dataset;
       }
    }
}
