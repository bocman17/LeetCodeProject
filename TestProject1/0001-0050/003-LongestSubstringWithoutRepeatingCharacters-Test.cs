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
    public class _003_LongestSubstringWithoutRepeatingCharacters_Test
    {
        [Test]
        public void LengthOfLongestSubstringTest()
        {
            string input = "abcabcbb";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();

            var result = solution.LengthOfLongestSubstring(input);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void LengthOfLongestSubstringTest_RepeatChars()
        {
            string input = "bbbbb";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();

            var result = solution.LengthOfLongestSubstring(input);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void LengthOfLongestSubstringTest_Emptyinput()
        {
            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();

            var result = solution.LengthOfLongestSubstring("");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void LengthOfLongestSubstringTest_LongString()
        {
            string input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();

            var result = solution.LengthOfLongestSubstring(input);

            Assert.That(result, Is.EqualTo(26));
        }

        [Test]
        public void LengthOfLongestSubstringTest_HaveShortRepeata()
        {
            string input = "abcdefghijklmnopqrstuvwxyzabcdefghijk  lmnopqrstuvwxyz";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();

            var result = solution.LengthOfLongestSubstring(input);

            Assert.That(result, Is.EqualTo(27));
        }

    }
}
