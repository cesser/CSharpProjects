using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCompletionSource
{
    public class ReturnClass
    {
        public string Status
        {
            get;
            set;
        }

        public ReturnClass()
        {
            this.Status = "Strat";
        }

        public async Task<ReturnClass> InitializeAsync()
        {
            await Task.Run(() => { this.DoSomething(); });
            return this;
        }

        private void DoSomething()
        {
            System.Threading.Thread.Sleep(3000);
            this.Status = "Done";
        }
    }
}
