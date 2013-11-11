using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewPrograms;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for PermutationTest
    /// </summary>
    [TestClass]
    public class PermutationTest
    {
        private Permutation permutation = new Permutation();

        [TestMethod]
        public void RecusivePermutation1()
        {
            int[] array = { 1,2,3};

            List<List<int>> result = permutation.RecusiveSlove(array);
            Assert.AreEqual(6 ,result.Count );
        }

        [TestMethod]
        public void RecusivePermutation2()
        {
            int[] array = { 1,2,2};

            List<List<int>> result = permutation.RecusiveSlove(array);
            Assert.AreEqual(3 ,result.Count );
        }

        [TestMethod]
        public void RecusivePermutation3()
        {
            int[] array = { 1, 2, 2, 2 };

            List<List<int>> result = permutation.RecusiveSlove(array);
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void RecusivePermutation4()
        {
            int[] array = { 1, 2, 2, 2 ,3};

            List<List<int>> result = permutation.RecusiveSlove(array);
            Assert.AreEqual(20, result.Count);
        }

        [TestMethod]
        public void RecusivePermutation5()
        {
            int[] array = { 1, 2, 2, 3 };

            List<List<int>> result = permutation.RecusiveSlove(array);
            Assert.AreEqual(12, result.Count);
        }

        [TestMethod]
        public void RecusivePermutation6()
        {
            int[] array = { 1, 2, 2, 3, 3 };

            List<List<int>> result = permutation.RecusiveSlove(array);
            Assert.AreEqual(30, result.Count);
        }
    }
}
