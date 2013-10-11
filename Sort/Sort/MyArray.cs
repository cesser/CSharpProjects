using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class MyArray
    {
        private int[] array;


        public int ArraySize { get; private set; }

        public int UpperIndex { get; private set; }

        public MyArray(int size)
        {
            if (size <= 0)
                throw new ArgumentException();

            array = new int[size];
            this.ArraySize = size;
            this.UpperIndex = size - 1;

            Random r = new Random();
            for (int i = 0; i < this.ArraySize; i++)
            {
                this.array[i] = r.Next(100);
            }
        }

        public void DisplayArray()
        {
            for (int i = 0; i < this.ArraySize; i++)
            {
                Console.Write(this.array[i].ToString(), @"\t");
            }
            
        }
    }
}
