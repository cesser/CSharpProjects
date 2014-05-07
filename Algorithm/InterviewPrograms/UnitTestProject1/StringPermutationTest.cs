using InterviewPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class StringPermutationTest
    {
        private StringPermutation stringPerm = new StringPermutation();

        [TestMethod]
        public void Test1()
        {
            string s = "abc";
            var result = stringPerm.GetAllPermuation(s);

            Assert.AreEqual(result.Length, 6);

            s = "abcd";
            result = stringPerm.GetAllPermuation(s);

            Assert.AreEqual(result.Length, 24);
        }

    }
}
