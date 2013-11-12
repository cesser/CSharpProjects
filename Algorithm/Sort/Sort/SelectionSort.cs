using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class SelectionSort
    {
        public static void SelectionSortTest()
        {
            Console.WriteLine("Selection sort");
            MyArray array = new MyArray(10);
            array.DisplayArray();
            SelectionSort1(array);
        }


        private static void SelectionSort1(MyArray array)
        {
            int minIndex = 0;
            int counter = 0;
            for (int i = 0; i < array.ArraySize; i++)
            {
                minIndex = i;
                for (int j = i+1; j < array.ArraySize; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                    counter++;
                }

                if (minIndex != i)
                {
                    int temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }

                Console.Write("Outer loop:  ");
                array.DisplayArray();
            }
        }

    }
}
