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
    public class _007_ReverseInteger_Test
    {
        [Test]
        public void ReverseTest_Positive()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(1);
            Assert.That(result, Is.EqualTo(1));

            result = solution.Reverse(123);
            Assert.That(result, Is.EqualTo(321));

            result = solution.Reverse(321);
            Assert.That(result, Is.EqualTo(123));
        }

        [Test]
        public void ReverseTest_Negative()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(-1);
            Assert.That(result, Is.EqualTo(-1));

            result = solution.Reverse(-123);
            Assert.That(result, Is.EqualTo(-321));

            result = solution.Reverse(-321);
            Assert.That(result, Is.EqualTo(-123));
        }

        [Test]
        public void ReverseTest_EqualZero()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void ReverseTest_PositiveOverFlow()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(1534236469);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void ReverseTest_NegativeOverFlow()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(-1534236469);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
