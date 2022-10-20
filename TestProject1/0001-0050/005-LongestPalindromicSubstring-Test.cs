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
    public class _005_LongestPalindromicSubstring_Test
    {
        [Test]
        public void LongestPalindromeTest_Odd()
        {
            var input = "abcdefgfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("abcdefgfedcba"));
        }

        [Test]
        public void LongestPalindromeTest_Even()
        {
            var input = "abcdefggfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("abcdefggfedcba"));
        }

        [Test]
        public void LongestPalindromeTest_AllTheSame_Odd()
        {
            var input = "ccc";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("ccc"));
        }

        [Test]
        public void LongestPalindromeTest_AllTheSame_Even()
        {
            var input = "aaaaaaaaaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("aaaaaaaaaa"));
        }

        [Test]
        public void LongestPalindromeTest_EmptyString()
        {
            var input = "";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void LongestPalindromeTest_OneCharacterString()
        {
            var input = "a";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("a"));
        }

        [Test]
        public void LongestPalindromeTest_MultiplePalindrome_LongestAtStart()
        {
            var input = "aabccdccbaaeeggee";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("aabccdccbaa"));
        }

        [Test]
        public void LongestPalindromeTest_MultiplePalindrome_LongestAtEnd()
        {
            var input = "eegffgeeaabcdcbaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("aabcdcbaa"));
        }

        [Test]
        public void LongestPalindromeTest_MultipleMixPalindrome()
        {
            var input = "abcdcbbcd";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("dcbbcd"));
        }

        [Test]
        public void LongestPalindromeTest_MultipleMixPalindrome_2()
        {
            var input = "abcddcbebcd";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("dcbebcd"));
        }

        [Test]
        public void LongestPalindromeTest_ReallyLongInput()
        {
            var input = "jglknendplocymmvwtoxvebkekzfdhykknufqdkntnqvgfbahsljkobhbxkvyictzkqjqydczuxjkgecdyhixdttxfqmgksrkyvopwprsgoszftuhawflzjyuyrujrxluhzjvbflxgcovilthvuihzttzithnsqbdxtafxrfrblulsakrahulwthhbjcslceewxfxtavljpimaqqlcbrdgtgjryjytgxljxtravwdlnrrauxplempnbfeusgtqzjtzshwieutxdytlrrqvyemlyzolhbkzhyfyttevqnfvmpqjngcnazmaagwihxrhmcibyfkccyrqwnzlzqeuenhwlzhbxqxerfifzncimwqsfatudjihtumrtjtggzleovihifxufvwqeimbxvzlxwcsknksogsbwwdlwulnetdysvsfkonggeedtshxqkgbhoscjgpiel";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.That(result, Is.EqualTo("sknks"));
        }
    }
}
