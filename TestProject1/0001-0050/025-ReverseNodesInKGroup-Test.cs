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
    public class _025_ReverseNodesInKGroup_Test
    {
        [Test]
        public void ReverseKGroupTest()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(input, 2);
            AssertHelper.AssertLinkList(new int[] { 2, 1, 4, 3, 5 }, result);

            input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            result = solution.ReverseKGroup(input, 3);
            AssertHelper.AssertLinkList(new int[] { 3, 2, 1, 4, 5 }, result);
        }

        [Test]
        public void ReverseKGroupTest_EmptyList()
        {
            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(null, 2);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void ReverseKGroupTest_KEqualZero()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(input, 0);
            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Test]
        public void ReverseKGroupTest_KEqualOne()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(input, 1);
            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Test]
        public void ReverseKGroupTest_KEqualLength()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(input, 5);
            AssertHelper.AssertLinkList(new int[] { 5, 4, 3, 2, 1 }, result);
        }

        [Test]
        public void ReverseKGroupTest_KLargerThanLength()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(input, 6);
            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }
    }
}
