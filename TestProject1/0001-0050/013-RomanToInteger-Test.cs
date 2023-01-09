using LeetCode._0001_0050;
using NUnit.Framework;

namespace LeetCode.Test._0001_0050
{
    [TestFixture]
    public class _013_RomanToInteger_Test
    {
        [Test]
        public void RomanToIntTest_LessThan10()
        {
            var solution = new _013_RomanToInteger();

            var result = solution.RomanToInt("I");
            Assert.That(result, Is.EqualTo(1));

            result = solution.RomanToInt("IV");
            Assert.That(result, Is.EqualTo(4));

            result = solution.RomanToInt("V");
            Assert.That(result, Is.EqualTo(5));

            result = solution.RomanToInt("VI");
            Assert.That(result, Is.EqualTo(6));

            result = solution.RomanToInt("IX");
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void RomanToIntTest_LessThan100()
        {
            var solution = new _013_RomanToInteger();

            var result = solution.RomanToInt("X");
            Assert.That(result, Is.EqualTo(10));

            result = solution.RomanToInt("XL");
            Assert.That(result, Is.EqualTo(40));

            result = solution.RomanToInt("L");
            Assert.That(result, Is.EqualTo(50));

            result = solution.RomanToInt("LXXIV");
            Assert.That(result, Is.EqualTo(74));

            result = solution.RomanToInt("XC");
            Assert.That(result, Is.EqualTo(90));
        }

        [Test]
        public void RomanToIntTest_LessThan1000()
        {
            var solution = new _013_RomanToInteger();

            var result = solution.RomanToInt("C");
            Assert.That(result, Is.EqualTo(100));

            result = solution.RomanToInt("CD");
            Assert.That(result, Is.EqualTo(400));

            result = solution.RomanToInt("D");
            Assert.That(result, Is.EqualTo(500));

            result = solution.RomanToInt("DCCXLIV");
            Assert.That(result, Is.EqualTo(744));

            result = solution.RomanToInt("CM");
            Assert.That(result, Is.EqualTo(900));
        }

        [Test]
        public void RomanToIntTest_LessThan4000()
        {
            var solution = new _013_RomanToInteger();

            var result = solution.RomanToInt("M");
            Assert.That(result, Is.EqualTo(1000));

            result = solution.RomanToInt("MMCDXCIV");
            Assert.That(result, Is.EqualTo(2494));
        }
    }
}
