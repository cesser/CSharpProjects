using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    /// <summary>
    /// Bubble sort, will replace from first item 
    /// </summary>
    public static class BubbleSort
    {
        public static void BubbleTest()
        {
            MyArray array = new MyArray(10);
            array = new MyArray(new int[] { 1, 2, 3, 4, 5 });
            array.DisplayArray();

            Console.WriteLine();
            Console.WriteLine("Bubble sort");
            BubbleSort.BubbleSort1(array);
            BubbleSort.BubbleSort2(array);
        }

        /// <summary>
        /// Basic bubble sorting function
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static void BubbleSort1(MyArray array)
        {
            int counter = 0;
            array = array.Clone();
            for (int i = array.UpperIndex; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                    //Console.Write("     Inner loop:  " );
                    //array.DisplayArray();

                    counter++;
                }

                Console.Write("Outer loop:  ");
                array.DisplayArray();
            }

            Console.WriteLine("Counter: " + counter.ToString());
        }

        /// <summary>
        /// Basic bubble sorting function
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static void BubbleSort2(MyArray array)
        {
            array = array.Clone();
            int counter = 0;
            for (int i = array.UpperIndex; i >= 0; i--)
            {
                bool hasSwap = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        hasSwap = true;
                    }
                    //Console.Write("     Inner loop:  ");
                    //array.DisplayArray();

                    counter++;
                }

                Console.Write("Outer loop:  ");
                array.DisplayArray();

                if (!hasSwap)
                    break;
            }

            Console.WriteLine("Counter: " + counter.ToString());
        }
    }
}
