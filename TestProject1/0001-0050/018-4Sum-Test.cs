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
    public class _018_4Sum_Test
    {
        [Test]
        public void FourSumTest()
        {
            int[] input = { 1, 0, -1, 0, -2, 2 };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);

            Assert.That(result, Has.Count.EqualTo(3));
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { -2, -1, 1, 2},
                new List<int> { -2, 0, 0, 2 },
                new List<int> { -1, 0, 0, 1 }
            }, result);
        }

        [Test]
        public void FourSumTest_2()
        {
            int[] input = { 1, 4, -3, 0, 0, 0, 5, 0 };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);

            Assert.That(result, Has.Count.EqualTo(1));
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { 0, 0, 0, 0 }
            }, result);
        }

        [Test]
        public void FourSumTest_Empty()
        {
            int[] input = { };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);

            Assert.That(result, Has.Count.EqualTo(0));
        }

        [Test]
        public void FourSumTest_NotEnough()
        {

            var solution = new _018_4Sum();

            int[] input1 = { -1 };
            var result = solution.FourSum(input1, 0);
            Assert.That(result, Has.Count.EqualTo(0));

            int[] input2 = { -1, 0 };
            result = solution.FourSum(input2, 1);
            Assert.That(result, Has.Count.EqualTo(0));

            int[] input3 = { -1, 0, 1 };
            result = solution.FourSum(input3, 1);
            Assert.That(result, Has.Count.EqualTo(0));

        }

        [Test]
        public void FourSumTest_AllTheSame()
        {
            int[] input = { 0, 0, 0, 0, 0, 0 };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);

            Assert.That(result, Has.Count.EqualTo(1));
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { 0, 0, 0, 0 }
            }, result);

            result = solution.FourSum(input, 1);
            Assert.That(result, Has.Count.EqualTo(0));
        }

        [Test]
        public void FourSumTest_SomeDuplicate()
        {
            int[] input = { 1, 0, 0, 1, 0, 0, -1, -1, 0, 0 };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);

            Assert.That(result, Has.Count.EqualTo(3));
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { -1, -1, 1, 1 },
                new List<int> { -1, 0, 0, 1 },
                new List<int> { 0, 0, 0, 0 }
            }, result);

            result = solution.FourSum(input, 1);
            Assert.That(result, Has.Count.EqualTo(2));
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { -1, 0, 1, 1 },
                new List<int> { 0, 0, 0, 1  },
            }, result);
        }
    }
}
