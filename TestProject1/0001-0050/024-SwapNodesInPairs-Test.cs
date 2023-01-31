using LeetCode._0001_0050;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0050
{
    [TestFixture]
    public class _024_SwapNodesInPairs_Test
    {
        [Test]
        public void SwapPairsTest()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input);

            AssertHelper.AssertLinkList(new int[] { 2, 1, 4, 3 }, result);
        }

        [Test]
        public void SwapPairsTest_EmptyList()
        {
            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(null);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void SwapPairsTest_OnlyOneNode()
        {
            var input = TestHelper.GenerateList(new int[] { 1 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input);

            AssertHelper.AssertLinkList(new int[] { 1 }, result);
        }

        [Test]
        public void SwapPairsTest_OddLength()
        {
            var input1 = TestHelper.GenerateList(new int[] { 1, 2, 3 });
            var input2 = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input1);

            AssertHelper.AssertLinkList(new int[] { 2, 1, 3 }, result);

            result = solution.SwapPairs(input2);
            AssertHelper.AssertLinkList(new int[] { 2, 1, 4, 3, 6, 5, 7 }, result);

        }
    }
}
