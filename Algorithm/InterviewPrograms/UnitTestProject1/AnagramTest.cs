using InterviewPrograms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class AnagramTest
    {
        Anagram a = new Anagram();
        [TestMethod]
        public void TestAnagram()
        {
            Assert.IsTrue(a.CheckAnagram("aabb", "abab"));
            string string1 = "acb";
            string string2 = "abc";
            Assert.IsTrue(a.CheckAnagram2(string1,string2));
        }
    }
}
