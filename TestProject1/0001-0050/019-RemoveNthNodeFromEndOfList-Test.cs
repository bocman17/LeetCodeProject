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
    public class _019_RemoveNthNodeFromEndOfList_Test
    {
        [Test]
        public void RemoveNthFromEndTest()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthNodeFromEndOfList(input, 2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 5 }, result);
        }

        [Test]
        public void RemoveNthFromEndTest_ListNull()
        {
            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthNodeFromEndOfList(null, 2);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void RemoveNthFromEndTest_NEqualZero()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthNodeFromEndOfList(input, 0);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void RemoveNthFromEndTest_NLessThanZero()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthNodeFromEndOfList(input, -1);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void RemoveNthFromEndTest_NLargerThanList()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthNodeFromEndOfList(input, 6);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Test]
        public void RemoveNthFromEndTest_FirstOne()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthNodeFromEndOfList(input, 5);

            AssertHelper.AssertLinkList(new int[] { 2, 3, 4, 5 }, result);
        }

        [Test]
        public void RemoveNthFromEndTest_LastOne()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthNodeFromEndOfList(input, 1);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4 }, result);
        }
    }
}
