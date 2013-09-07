using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRProject
{
    class Program
    {
       
        enum MyEnum
        { 
            One,
            Tow
        }

        static void Main(string[] args)
        {
            TestClassForRef tc = new TestClassForRef();
            tc.Test();
            Console.Read();
        }

        private static void TestValueType()
        {
            Console.WriteLine(Activator.CreateInstance(typeof(double)));
            Console.WriteLine(typeof(UInt16).IsValueType);
            Console.WriteLine(typeof(string).IsValueType);
            Console.WriteLine(typeof(MyEnum).IsValueType);
            MyEnum one = MyEnum.One;
            Console.WriteLine(one.GetType().IsValueType);
        }
    }


}
