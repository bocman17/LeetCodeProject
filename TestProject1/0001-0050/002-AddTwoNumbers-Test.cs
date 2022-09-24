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
    public class _002_AddTwoNumbers_Test
    {
        [Test]
        public void AddTwoNumbers_General()
        {
            var link = TestHelper.GenerateList(new int[] { 2, 4, 3 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList(new int[] { 4, 8, 6 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_2()
        {
            var link = TestHelper.GenerateList(new int[] { 0 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList(new int[] { 0 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_HasCarry()
        {
            var link1 = TestHelper.GenerateList(new int[] { 2, 4, 3 });
            var link2 = TestHelper.GenerateList(new int[] { 5, 6, 4 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_HasMultipleCarry()
        {
            var link1 = TestHelper.GenerateList(new int[] { 1 });
            var link2 = TestHelper.GenerateList(new int[] { 9, 9 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 0, 0, 1 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_FirstNumCarry()
        {
            var link1 = TestHelper.GenerateList(new int[] { 3, 4, 4 });
            var link2 = TestHelper.GenerateList(new int[] { 3, 4, 6 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 6, 8, 0, 1 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_L1Longer()
        {
            var link1 = TestHelper.GenerateList(new int[] { 2, 4, 3, 1 });
            var link2 = TestHelper.GenerateList(new int[] { 5, 6, 4 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8, 1 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_L1Longer_2()
        {
            var link1 = TestHelper.GenerateList(new int[] { 1, 8 });
            var link2 = TestHelper.GenerateList(new int[] { 0 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_L1Empty()
        {
            var link1 = TestHelper.GenerateList(null);
            var link2 = TestHelper.GenerateList(new int[] { 1, 8 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_L2Longer()
        {
            var link1 = TestHelper.GenerateList(new int[] { 2, 4, 3 });
            var link2 = TestHelper.GenerateList(new int[] { 5, 6, 4, 3 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8, 3 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_L2Longer_2()
        {
            var link1 = TestHelper.GenerateList(new int[] { 0 });
            var link2 = TestHelper.GenerateList(new int[] { 1, 8 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [Test]
        public void AddTwoNumbers_General_L2Empty()
        {
            var link1 = TestHelper.GenerateList(new int[] { 1, 8 });
            var link2 = TestHelper.GenerateList(null);

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }
    }
}
