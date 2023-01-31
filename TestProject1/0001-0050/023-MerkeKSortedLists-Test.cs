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
    public class _023_MerkeKSortedLists_Test
    {
        [Test]
        public void MergeKListsTest()
        {
            var input = new ListNode[]
            {
                TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 }),
                TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 })
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [Test]
        public void MergeKListsTest_2()
        {
            var input = new ListNode[]
            {
                TestHelper.GenerateList(new int[] {  1, 3, 7  }),
                TestHelper.GenerateList(new int[] { 2, 10 }),
                TestHelper.GenerateList(new int[] { 5, 9 }),
                TestHelper.GenerateList(new int[] { 4, 6, 8 }),
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [Test]
        public void MergeKListsTest_OneList()
        {
            var input = new ListNode[]
            {
                TestHelper.GenerateList(new int[] {  1, 2, 3  }),
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3 }, result);
        }

        [Test]
        public void MergeKListsTest_EmptyList()
        {
            var input = new ListNode[]
            {
                TestHelper.GenerateList(new int[] {}),
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            Assert.That(result, Is.Null);
        }
    }
}
