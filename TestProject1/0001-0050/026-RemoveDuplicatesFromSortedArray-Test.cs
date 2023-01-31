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
    public class _026_RemoveDuplicatesFromSortedArray_Test
    {
        [Test]
        public void RemoveDuplicatesTest()
        {
            var input = new int[] { 1, 1, 2 };

            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(input);

            Assert.That(result, Is.EqualTo(2));
            AssertHelper.AssertArray(new int[] { 1, 2 }, input, true);
        }

        [Test]
        public void RemoveDuplicatesTest_EmptyInput()
        {
            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(new int[] { });

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void RemoveDuplicatesTest_OneItem()
        {
            var input = new int[] { 1 };

            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(input);

            Assert.That(result, Is.EqualTo(1));
            AssertHelper.AssertArray(new int[] { 1 }, input);
        }
    }
}
