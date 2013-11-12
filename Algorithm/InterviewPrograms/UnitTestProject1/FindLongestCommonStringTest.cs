using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewPrograms;

namespace UnitTestProject1
{
    [TestClass]
    public class FindLongestCommonStringTest
    {
        FindLongestCommonString findLCS = new FindLongestCommonString();
        [TestMethod]
        public void FindLCS1()
        {
            string string1 = "123abcdfabc";
            string string2 = "jj12hhjgdsabcddk";
            string result = findLCS.FindLCS(string1, string2);

            Assert.IsTrue(string1.Contains(result));
            Assert.IsTrue(string2.Contains(result));
            Assert.AreEqual("abcd", result);
        }

        [TestMethod]
        public void FindLCS2()
        {
            string string1 = "123";
            string string2 = "as123df1234";
            string result = findLCS.FindLCS(string1, string2);

            Assert.IsTrue(string1.Contains(result));
            Assert.IsTrue(string2.Contains(result));
            Assert.AreEqual("123", result);
        }
    }
}
