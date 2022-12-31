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
    public class _009_PalindromeNumber_Test
    {
        [Test]
        public void IsPalindromeTest_SingleDigit()
        {
            var solution = new _009_PalindromeNumber();

            var result = solution.IsPalindrome(1);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindromeTest_NegativeNumber()
        {
            var solution = new _009_PalindromeNumber();

            var result = solution.IsPalindrome(-1);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindromeTest_MultipleDigit()
        {
            var solution = new _009_PalindromeNumber();

            var result = solution.IsPalindrome(11);
            Assert.That(result, Is.True);

            result= solution.IsPalindrome(121);
            Assert.That(result, Is.True);

            result = solution.IsPalindrome(1231);
            Assert.That(result, Is.False);
        }

    }
}
