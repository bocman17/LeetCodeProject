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
    public class _021_MergeTwoSortedLists_Test
    {
        [Test]
        public void MergeTwoListsTest()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoSortedLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [Test]
        public void MergeTwoListsTest_List1Longer()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9, 11, 13 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoSortedLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13 }, result);
        }

        [Test]
        public void MergeTwoListsTest_List2Longer()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10, 12, 14 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoSortedLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 }, result);
        }

        [Test]
        public void MergeTwoListsTest_List1Empty()
        {
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoSortedLists(null, list2);

            AssertHelper.AssertLinkList(new int[] { 2, 4, 6, 8, 10 }, result);
        }

        [Test]
        public void MergeTwoListsTest_List2Empty()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoSortedLists(list1, null);

            AssertHelper.AssertLinkList(new int[] { 1, 3, 5, 7, 9 }, result);
        }

        [Test]
        public void MergeTwoListsTest_BothListEmpty()
        {

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoSortedLists(null, null);

            Assert.That(result, Is.Null);
        }
    }
}
