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
    public class _016_3SumClosest_Test
    {
        [Test]
        public void ThreeSumClosestTest_NotMatch()
        {
            int[] input = { -1, 2, 1, -4 };

            var solution = new _016_3SumClosest();

            var result = solution.ThreeSumClosest(input, 1);
            Assert.That(result, Is.EqualTo(2));

            result = solution.ThreeSumClosest(input, -2);
            Assert.That(result, Is.EqualTo(-3));
        }

        [Test]
        public void ThreeSumClosestTest_NotMatch_Duplicate()
        {
            int[] input1 = { 0, 0, 0 };
            int[] input2 = { 1, 1, 1, 1 };

            var solution = new _016_3SumClosest();

            var result = solution.ThreeSumClosest(input1, 1);
            Assert.That(result, Is.EqualTo(0));

            result = solution.ThreeSumClosest(input2, 0);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ThreeSumClosestTest_HaveMatch()
        {
            int[] input = { -1, 2, 1, -4 };

            var solution = new _016_3SumClosest();

            var result = solution.ThreeSumClosest(input, 2);
            Assert.That(result, Is.EqualTo(2));

            result = solution.ThreeSumClosest(input, -1);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void ThreeSumClosestTest_HaveMatch_2()
        {
            int[] input = { 1, 1, -1, -1, 3 };

            var solution = new _016_3SumClosest();

            var result = solution.ThreeSumClosest(input, 1);
            Assert.That(result, Is.EqualTo(1));

            result = solution.ThreeSumClosest(input, -1);
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}
