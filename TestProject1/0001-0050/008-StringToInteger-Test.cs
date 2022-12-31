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
    public class _008_StringToInteger_Test
    {
        [Test]
        public void MyAtoiTest_Positive()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("123");
            Assert.That(result, Is.EqualTo(123));
        }

        [Test]
        public void MyAtoiTest_Negative()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-123");
            Assert.That(result, Is.EqualTo(-123));
        }

        [Test]
        public void MyAtoiTest_Zero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("0");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MyAtoiTest_PositiveZero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("+0");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MyAtoiTest_NegativeZero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-0");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MyAtoiTest_Boundary()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("2147483647");
            Assert.That(result, Is.EqualTo(2147483647));

            result = solution.MyAtoi("2147483646");
            Assert.That(result, Is.EqualTo(2147483646));

            result = solution.MyAtoi("-2147483648");
            Assert.That(result, Is.EqualTo(-2147483648));

            result = solution.MyAtoi("-2147483647");
            Assert.That(result, Is.EqualTo(-2147483647));
        }

        [Test]
        public void MyAtoiTest_PositiveOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("2147483648");
            Assert.That(result, Is.EqualTo(int.MaxValue));

            result = solution.MyAtoi("2247483647");
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void MyAtoiTest_NagativeOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-2147483649");
            Assert.That(result, Is.EqualTo(int.MinValue));

            result = solution.MyAtoi("-2247483648");
            Assert.That(result, Is.EqualTo(int.MinValue));
        }

        [Test]
        public void MyAtoiTest_WhiteSpaceInFrontOfInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("   123");
            Assert.That(result, Is.EqualTo(123));

            result = solution.MyAtoi("   -123");
            Assert.That(result, Is.EqualTo(-123));
        }

        [Test]
        public void MyAtoiTest_EmptyString()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("");
            Assert.That(result, Is.EqualTo(0));

            result = solution.MyAtoi("   ");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MyAtoiTest_InvalidInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("abc");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MyAtoiTest_MixInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("123abc");
            Assert.That(result, Is.EqualTo(123));

            result = solution.MyAtoi("-123abc");
            Assert.That(result, Is.EqualTo(-123));
        }

        [Test]
        public void MyAtoiTest_MixInputWithOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("  2147483648abc");
            Assert.That(result, Is.EqualTo(int.MaxValue));

            result = solution.MyAtoi("  2247483647abc");
            Assert.That(result, Is.EqualTo(int.MaxValue));

            result = solution.MyAtoi("  -2147483649abc");
            Assert.That(result, Is.EqualTo(int.MinValue));

            result = solution.MyAtoi("  -2247483648abc");
            Assert.That(result, Is.EqualTo(int.MinValue));
        }
    }
}
