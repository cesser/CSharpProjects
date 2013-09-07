using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRProject
{
    public class TestClassForRef
    {
        public TestClass A { get; set; }

        public TestClass Update(ref TestClass a)
        {
            a = new TestClass();
            return a;
        }

        public TestClass Update(TestClass a)
        {
            a = new TestClass();
            return a;
        }

        public void Update(ref int a)
        {
            a = 10;
            
        }

        public void Check(TestClass a)
        {
            Console.WriteLine(a == A);
            a = new TestClass();
            Console.WriteLine(a == A);
        }

        public void Test()
        {
            Check(A);
        }
    }


    public class TestClass
    {
        public string Name { get; set; }
    }
}
