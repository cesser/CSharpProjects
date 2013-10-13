using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class QuickSort
    {
        public static void QuickSortTest()
        {
            MyArray array = new MyArray(10);
            array.DisplayArray();

            Console.WriteLine("Quick Sort");

            QuickSort1(array);
        }

        private static void QuickSort1(MyArray array)
        {
            int key = 0;

            for (int i = array.UpperIndex; i >= 0 ; i--)
            {
                if (array[key] > array[i])
                {
                    int temp = array[key];
                    array[key] = array[i];
                    array[i] = temp; 
                }
            }
        }
    }
}
