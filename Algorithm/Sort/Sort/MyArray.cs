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

        public int this[int i]
        {
            get { return this.array[i]; }
            set { this.array[i] = value; }
        }

        public int ArraySize { get; private set; }

        public int UpperIndex { get; private set; }

        public MyArray(int[] array) 
        {
            if (array == null)
                throw new ArgumentNullException();

            this.array = (int[])array.Clone();
            this.ArraySize = this.array.Length;
            this.UpperIndex = this.ArraySize - 1;
        }
        
        
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

        public MyArray Clone()
        {
            MyArray newArray = new MyArray(this.array);
            return newArray;
        }

        public void DisplayArray()
        {
            for (int i = 0; i < this.ArraySize; i++)
            {
                Console.Write(this.array[i].ToString()+ "   ");
            }
            Console.WriteLine();
        }
        
        public void DisplayArray(int startIndex, int endIndex)
        {
        	for (int i = startIndex; i <= (endIndex > this.UpperIndex ? this.UpperIndex : endIndex) ; i++)
            {
                Console.Write(this.array[i].ToString()+ "   ");
            }
            Console.WriteLine();
        }
    }
}
