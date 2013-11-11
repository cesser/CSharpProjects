using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenArray(20);
            DisplayArray(array);
            Search.SortArray_QuickSort(array);
            DisplayArray(array);

            while (true)
            {
                
                
                
                
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine(Search.BinarySearch(number, array));

            }
            
            Console.Read();
        }

        static int[] GenArray(int arrayLength)
        {
            int[] array = new int[arrayLength];

            Random r = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = r.Next(100);
            }

            return array;
        }

        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
