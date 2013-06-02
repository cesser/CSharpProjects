using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
       // function fib(n)
       //if n = 0 return 0
       //if n = 1 return 1
       //return fib(n − 1) + fib(n − 2)

        static void Main(string[] args)
        {
            Console.WriteLine(Fib(10));
            Console.WriteLine(NonRecursiveFib(10));

            Console.Read();
        }

        static int Fib(int n)
        {
            if (n < 0) return -1;

            if (n == 0) return n;
            if (n == 1) return n;

            return Fib(n - 1) + Fib(n - 2);
        }


        static int NonRecursiveFib(int n)
        {
            if (n < 0) return -1;

            if (n == 0) return n;
            if (n == 1) return n;

            int result = 0;

            Stack<int> stack = new Stack<int>();

            stack.Push(n);
            while (stack.Count > 0)
            {
                int x = stack.Pop();
                //Console.WriteLine(x);

                if (x == 1 || x == 0)
                {
                    result += x;
                }
                else
                {
                    stack.Push(x - 1);
                    stack.Push(x - 2);
                }
            }

            return result;
        }
    }
}
