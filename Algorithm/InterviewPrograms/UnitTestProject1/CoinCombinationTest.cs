using InterviewPrograms.Recusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class CoinCombinationTest
    {
        CoinCombination p = new CoinCombination();

        [TestMethod]
        public void Test1()
        {
            var result = p.GetCoinCombinationCount(25, 25);

            result = p.GetCoinCombinationCount(100, 25);
          
        }

    }
}
