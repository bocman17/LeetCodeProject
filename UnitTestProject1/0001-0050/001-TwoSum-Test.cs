using LeetCode._0001_0050;
using NUnit.Framework;
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

            Assert.Equals(2, result.Length);
            Assert.Equals(0, result[0]);
            Assert.Equals(1, result[1]);
        }
    }
}
