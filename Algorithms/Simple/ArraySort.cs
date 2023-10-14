using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Simple
{
    public class ArraySort
    {
        public void SortNumbers()
        {
            int[] intArray = new int[] {9,2,4,3,1,-9,5};
            Console.WriteLine("Original array");
           foreach (int i in intArray)
           {
               Console.Write(i + " ");
           }

           // Sort array in ASC order
           Console.WriteLine("Sorted array in ASC order");
           Array.Sort(intArray);
           foreach (int i in intArray)
           {
               Console.Write(i + " ");
           }
           Console.WriteLine();
           Console.WriteLine("Sorted array in DESC order");

           // Sort Array in DESC order
           Array.Reverse(intArray);
           foreach (int i in intArray)
           {
               Console.Write(i + " ");
           }
           Console.WriteLine();

        }
    
        public void SortString()
        {
            // Array of strings
            string[] strArray = new string[] { "Mahesh", "David", "Allen", "Joe", "Monica" };
            Console.WriteLine();
            Console.WriteLine("Original array");
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            // Sort array
            Array.Sort(strArray);
            // Read array items using foreach loop
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            Array.Reverse(strArray);
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    
        public void SortRangeOfElement()
        {
            // Array of integers
            int[] intArray = new int[] { 9, 2, 4, 3, 1, 5, 6, 9, 5, 7, 1, 0 };

            // Sort array from 1st element to 6th element. Skil 0th element.
            Array.Sort(intArray, 1, 6);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
