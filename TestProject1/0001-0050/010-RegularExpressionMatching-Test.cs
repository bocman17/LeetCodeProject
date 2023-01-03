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
    public class _010_RegularExpressionMatching_Test
    {
        [Test]
        public void IsMatchingTest_CharacterNotMatch()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("aa", "a");
            Assert.That(result, Is.False);

            result = solution.IsMatch("aaa", "aa");
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMatchingTest_CharacterMatch()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("aa", "aa");
            Assert.That(result, Is.True);

            result = solution.IsMatch("abc", "abc");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMatchingTest_Star_Multiple()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("aa", "a*");
            Assert.That(result, Is.True);

            result = solution.IsMatch("aaa", "a*");
            Assert.That(result, Is.True);

            result = solution.IsMatch("aaaa", "b*");
            Assert.That(result, Is.False);

            result = solution.IsMatch("abcd", "d*");
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMatchingTest_Star_Zero()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("b", "a*b");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMatchingTest_MultipleStar()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("aab", "c*a*b");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMatchingTest_Dot()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("ab", ".b");
            Assert.That(result, Is.True);

            result = solution.IsMatch("ab", ".");
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMatchingTest_DotWithStar()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("aa", ".*");
            Assert.That(result, Is.True);

            result = solution.IsMatch("ab", ".*");
            Assert.That(result, Is.True);

            result = solution.IsMatch("abcdefg", ".*");
            Assert.That(result, Is.True);

            result = solution.IsMatch("bbbba", ".*a*a");
            Assert.That(result, Is.True);

            result = solution.IsMatch("ab", ".*c");
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMatchingTest_MultipleDot()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("aa", "..");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMatchingTest_StringNullOrEmpty()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("", ".");
            Assert.That(result, Is.False);

            result = solution.IsMatch("", ".*");
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMatchingTest_MatcherNullOrEmpty()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("abc", "");
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMatchingTest_StringAndMatcherBothNullOrEmpty()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("", "");
            Assert.That(result, Is.True);
        }
    }
}
