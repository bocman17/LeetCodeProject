using LeetCode._0001_0050;
using NUnit.Framework;

namespace LeetCode.Test._0001_0050
{
    [TestFixture]
    public class _001_TwoSum_Test
    {
        private int[] largeArray;

        public _001_TwoSum_Test()
        {
            largeArray = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                largeArray[i] = i * 2;
            }
        }

        [Test]
        public void TwoSumTest_Ordered()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result, Has.Length.EqualTo(2));
            Assert.Multiple(() =>
            {
                Assert.That(result[0], Is.EqualTo(0));
                Assert.That(result[1], Is.EqualTo(1));
            });
        }

        [Test]
        public void TwoSumTest_Unordered()
        {
            var nums = new int[] { 5, 75, 25 };
            var target = 100;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result, Has.Length.EqualTo(2));
            Assert.Multiple(() =>
            {
                Assert.That(result[0], Is.EqualTo(1));
                Assert.That(result[1], Is.EqualTo(2));
            });
        }

        [Test]
        public void TwoSumTest_Duplicate()
        {
            var nums = new int[] { 5, 5, 15, 30 };
            var target = 20;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result, Has.Length.EqualTo(2));
            Assert.Multiple(() =>
            {
                Assert.That(result[0], Is.EqualTo(1));
                Assert.That(result[1], Is.EqualTo(2));
            });
        }

        [Test]
        public void TwoSumTest_AllSame()
        {
            var nums = new int[] { 5, 5, 5, 5, 5 };
            var target = 10;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result, Has.Length.EqualTo(2));
            Assert.Multiple(() =>
            {
                Assert.That(result[0], Is.EqualTo(0));
                Assert.That(result[1], Is.EqualTo(1));
            });
        }

        [Test]
        public void TwoSumTest_NoTarget()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 5;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result, Has.Length.EqualTo(0));
        }
    }
}
