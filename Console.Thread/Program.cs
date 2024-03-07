// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Runtime.Intrinsics.X86;
using Newtonsoft.Json;
using System.Xml.Linq;
class Program
{
         static int maxNumbr = 0;
         static int minNumbr = 0;
         static int sumNumbr = 0;
 
    static  void Main()
    {
        int number;
        List<int> list = new List<int>();
        // StreamWriter writer = new StreamWriter("C:\\Users\\User\\source\\repos\\Console.Thread\\ new_file.txt");

        void thirdThread()
        {
        Random rnd = new Random();

        for (int i = 0;i < 100; i++)
        {
             number = rnd.Next(1,1000);
            Console.WriteLine(number);
                list.Add(number);
        }
        }
         void SortNumberMax()
        {
            maxNumbr = list.Max();
            Console.WriteLine("Max Numbr = " + maxNumbr);
           
        }
        void SortNumberMin()
        {
            minNumbr = list.Min();
            Console.WriteLine("Min Numbr = " + minNumbr);
        }
        void SumNumber()
        {
            sumNumbr = list.Sum();
            Console.WriteLine("Sum Numbr = " + sumNumbr);
         
        }

          void WriteFile()
          {
           
            using (StreamWriter writer = new StreamWriter("E:\\3 КУРС\\Console.Thread\\new_file.txt"))
            {

              foreach(int i in list)
              {
         
              writer.WriteLine(i);
            
              }
                writer.Close();
              
            }
         
          }
    
        
        thirdThread();
        Thread secondThread2 = new Thread(SortNumberMax);
         secondThread2.Start();
        Thread secondThread3 = new Thread(SortNumberMin);
        secondThread3.Start();
        Thread secondThread4 = new Thread(SumNumber);
        secondThread4.Start();
        Thread secondThread5 = new Thread(WriteFile);
        secondThread5.Start();
   
        Console.WriteLine("THE END Prodgect");
    }
}