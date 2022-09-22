using LeetCode._0001_0050;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0050
{
    [TestClass]
    public class _001_TwoSum_Test
    {
        private int[] largeArray;

        public _001_TwoSum_Test()
        {
            largeArray = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                largeArray[i] = i * 2;
            }
        }

        [TestMethod]
        public void TwoSumTest_Ordered()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartsWith("A");
                Assert.IsTrue(result,
                       string.Format("Expected for '{0}': true; Actual: {1}",
                                     word, result));
            }
        }
    }
}
