using LeetCode._0001_0050;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._0001_0050
{
    [TestFixture]
    public class _029_DivideTwoIntegers_Test
    {
        [Test]
        public void DivideTest()
        {
            var solution = new _029_DivideTwoIntegers();

            var result = solution.Divide(5, 2);
            Assert.That(result, Is.EqualTo(2));

            result = solution.Divide(-5, 2);
            Assert.That(result, Is.EqualTo(-2));

            result = solution.Divide(5, -2);
            Assert.That(result, Is.EqualTo(-2));

            result = solution.Divide(-5, -2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void DivideTest_DivisorEqualZero()
        {
            var solution = new _029_DivideTwoIntegers();

            void CheckFunction()
            {
                solution.Divide(5, 0);
            }

            Assert.Catch(typeof(DivideByZeroException), CheckFunction);
        }

        [Test]
        public void DivideTest_MaxValueDivideMaxValue()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, int.MaxValue);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void DivideTest_MinValueDivideMinValue()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, int.MinValue);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void DivideTest_DivisorLargerThanDividend()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(5, 10);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void DivideTest_MinValueDivideMinusOne()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, -1);

            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void DivideTest_MinValueDivideOne()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, 1);

            Assert.That(result, Is.EqualTo(int.MinValue));
        }

        [Test]
        public void DivideTest_MaxValueDivideMinusOne()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, -1);

            Assert.That(result, Is.EqualTo(int.MinValue + 1));
        }

        [Test]
        public void DivideTest_MaxValueDivideOne()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, 1);

            Assert.That(result, Is.EqualTo(int.MaxValue));
        }
    }
}
