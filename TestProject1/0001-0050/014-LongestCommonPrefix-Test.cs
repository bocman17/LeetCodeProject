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
    public class _014_LongestCommonPrefix_Test
    {
        [Test]
        public void LongestCommonPrefix_Empty()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new string[0]);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void LongestCommonPrefixTest_OneString()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new string[] {"abc"});
            Assert.That(result, Is.EqualTo("abc"));
        }

        [Test]
        public void LongestCommonPrefixTest_HavePrefix()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new string[] { "aa", "a" });
            Assert.That(result, Is.EqualTo("a"));

            result = solution.LongestCommonPrefix(new string[] { "a", "aa" });
            Assert.That(result, Is.EqualTo("a"));

            result = solution.LongestCommonPrefix(new string[] { "abcd", "abc", "abd" });
            Assert.That(result, Is.EqualTo("ab"));
        }

        [Test]
        public void LongestCommonPrefixTest_NoPrefix()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new string[] { "abc", "abd", "bcd" });
            Assert.That(result, Is.Empty);
        }
    }
}
