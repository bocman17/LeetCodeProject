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
    public class _027_RemoveElement_Test
    {
        [Test]
        public void RemoveElementTest()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 3);

            Assert.That(result, Is.EqualTo(4));
            AssertHelper.AssertArray(new int[] { 1, 2, 4, 5 }, input, true);
        }

        [Test]
        public void RemoveElementTest_EmptyInput()
        {

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(new int[] { }, 3);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void RemoveElementTest_OnlyOneItem_NotSame()
        {
            var input = new int[] { 1 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 3);

            Assert.That(result, Is.EqualTo(1));
            AssertHelper.AssertArray(new int[] { 1 }, input);
        }

        [Test]
        public void RemoveElementTest_OnlyOneItem_Same()
        {
            var input = new int[] { 1 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 1);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void RemoveElementTest_HaveMultipleValue()
        {
            var input = new int[] { 1, 2, 3, 3, 4, 5 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 3);

            Assert.That(result, Is.EqualTo(4));
            AssertHelper.AssertArray(new int[] { 1, 2, 4, 5 }, input, true);
        }

        [Test]
        public void RemoveElementTest_AllValue()
        {
            var input = new int[] { 3, 3, 3, 3, 3, 3 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 3);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
