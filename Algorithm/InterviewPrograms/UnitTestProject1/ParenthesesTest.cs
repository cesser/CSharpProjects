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
    public class ParenthesesTest
    {
        Parentheses p = new Parentheses();

        [TestMethod]
        public void Test1()
        {
            var result = p.GetAllParentheses(3);

            Assert.AreEqual(result.Length, 5);

            result = p.GetAllParentheses(2);
            Assert.AreEqual(result.Length, 2);
        }

    }
}
