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
    public class _012_IntegerToRoman_Test
    {
        [Test]
        public void IntToRomanTest_LessThan10()
        {
            var solution = new _012_IntegerToRoman();

            var result = solution.IntToRoman(1);
            Assert.That(result, Is.EqualTo("I"));

            result = solution.IntToRoman(4);
            Assert.That(result, Is.EqualTo("IV"));

            result = solution.IntToRoman(5);
            Assert.That(result, Is.EqualTo("V"));

            result = solution.IntToRoman(6);
            Assert.That(result, Is.EqualTo("VI"));

            result = solution.IntToRoman(9);
            Assert.That(result, Is.EqualTo("IX"));
        }

        [Test]
        public void IntToRomanTest_LessThan100()
        {
            var solution = new _012_IntegerToRoman();

            var result = solution.IntToRoman(10);
            Assert.That(result, Is.EqualTo("X"));

            result = solution.IntToRoman(40);
            Assert.That(result, Is.EqualTo("XL"));

            result = solution.IntToRoman(50);
            Assert.That(result, Is.EqualTo("L"));

            result = solution.IntToRoman(74);
            Assert.That(result, Is.EqualTo("LXXIV"));

            result = solution.IntToRoman(90);
            Assert.That(result, Is.EqualTo("XC"));
        }

        [Test]
        public void IntToRomanTest_LessThan1000()
        {
            var solution = new _012_IntegerToRoman();

            var result = solution.IntToRoman(100);
            Assert.That(result, Is.EqualTo("C"));

            result = solution.IntToRoman(400);
            Assert.That(result, Is.EqualTo("CD"));

            result = solution.IntToRoman(500);
            Assert.That(result, Is.EqualTo("D"));

            result = solution.IntToRoman(744);
            Assert.That(result, Is.EqualTo("DCCXLIV"));

            result = solution.IntToRoman(900);
            Assert.That(result, Is.EqualTo("CM"));
        }

        [Test]
        public void IntToRomanTest_LessThan4000()
        {
            var solution = new _012_IntegerToRoman();

            var result = solution.IntToRoman(1000);
            Assert.That(result, Is.EqualTo("M"));

            result = solution.IntToRoman(2494);
            Assert.That(result, Is.EqualTo("MMCDXCIV"));
        }

    }
}
