using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskCompletionSource
{
    class Program
    {
        static  void Main(string[] args)
        {
            AsyncTest();
            Console.WriteLine("Something else");
            Console.Read();
        }

        private async static void AsyncTest()
        {
            ReturnClass rc = new ReturnClass();
            Task<ReturnClass> result = rc.InitializeAsync();
            Console.WriteLine(rc.Status);
            await result;
            Console.WriteLine(result.Result.Status);
        }

        
    }
}
