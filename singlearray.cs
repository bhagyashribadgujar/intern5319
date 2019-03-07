using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace One_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring single dimensional array
            string[] Books = new string[5];
            Books[0] = "C#";
            Books[1] = "Java";
            Books[2] = "VB.NET";
            Books[3] = "C++";
            Books[4] = "C";
 
            Console.WriteLine("All the element of Books array is:\n\n");
 
            int i = 0;
            //Formatting Output
            Console.Write("\t1\t2\t3\t4\t5\n\n\t");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}\t", Books[i]);
            }
            Console.ReadLine();
        }
    }
}
