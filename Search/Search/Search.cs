using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public static class Search
    {

        public static void SortArray_QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length -1);
        }

        private static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
                return;

            int mid = Partition_QuickSort(array, start, end);
            //DisplayArray(array, start, mid);
            //DisplayArray(array, mid, end);
            QuickSort(array, start, mid -1);
            QuickSort(array, mid + 1, end);
        }

        private static void DisplayArray(int[] array, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(array[i] + "  ");
            }

            Console.WriteLine();
        }

        private static int Partition_QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
                return start;

            //use first element as mid
            int midElement = array[end];

            int tempIndex = start; //temp index is used to swap with smaller element
            for (int i = start; i < end ; i++)
            {
                if (array[i] < midElement)
                { 
                    //swap temp index and i
                    if (i != tempIndex)
                    {
                        int temp = array[i];
                        array[i] = array[tempIndex];
                        array[tempIndex] = temp; 
                    }
                    tempIndex++;
                }
            }

            //move midelement to tempindex
            array[end] = array[tempIndex];
            array[tempIndex] = midElement;

            return tempIndex;
        }

        public static int BinarySearch(int target, int[] array)
        {
            return BinarySearch(target, array, 0, array.Length -1);
        }

        private static int BinarySearch(int target, int[] array, int start, int end)
        {
            if (end < start)
                return -1;

            int midIndex = start + (end - start) / 2;

            if (array[midIndex] == target)
                return midIndex;

            if (array[midIndex] < target)
                return BinarySearch(target, array, midIndex + 1, end);
            else
                return BinarySearch(target, array, start, midIndex - 1);
        }

    }
}
