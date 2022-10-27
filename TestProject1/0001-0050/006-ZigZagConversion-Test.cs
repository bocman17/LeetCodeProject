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
    public class _006_ZigZagConversion_Test
    {
        [Test]
        public void ConvertTest_General()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigZagConversion();

            var result = solution.Convert(input, 3);
            Assert.That(result, Is.EqualTo("PAHNAPLSIIGYIR"));

            result = solution.Convert(input, 4);
            Assert.That(result, Is.EqualTo("PINALSIGYAHRPI"));

            result = solution.Convert(input, 5);
            Assert.That(result, Is.EqualTo("PHASIYIRPLIGAN"));
        }

        [Test]
        public void ConvertTest_RowNumberEqualOne()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigZagConversion();

            var result = solution.Convert(input, 1);
            Assert.That(result, Is.EqualTo(input));
        }

        [Test]
        public void ConvertTest_RowNumberEqualZero()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigZagConversion();

            var result = solution.Convert(input, 0);
            Assert.That(result, Is.EqualTo(input));
        }

        [Test]
        public void ConvertTest_EmptyString()
        {
            var input = string.Empty;

            var solution = new _006_ZigZagConversion();

            var result = solution.Convert(input, 2);
            Assert.That(result, Is.EqualTo(input));
        }
    }
}
