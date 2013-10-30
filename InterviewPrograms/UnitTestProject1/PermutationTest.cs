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
            int[] array = { 1,2,2,3};

            List<List<int>> result = permutation.RecusiveSlove(array);
            Assert.AreEqual(result.Count, 12);

            foreach (var item in result)
            {
                PrintArray(item);
            }

            Console.Read();
        }


        private void PrintArray(List<int> array)
        {
            foreach (var item in array)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
