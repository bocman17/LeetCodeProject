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
    public class _030_SubstringWithConcatenationOfAllWords_Test
    {
        [Test]
        public void FindSubstringTest()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" });

            AssertHelper.AssertList(new int[] { 0, 9 }, result);
        }

        [Test]
        public void FindSubstringTest_NoMatch()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar", "yeh" });

            AssertHelper.AssertList(new int[] { }, result);
        }

        [Test]
        public void FindSubstringTest_WordsEmpty()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("barfoothefoobarman", new string[] { });

            AssertHelper.AssertList(new int[] { }, result);
        }

        [Test]
        public void FindSubstringTest_AllTheSame()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("aaaaa", new string[] { "a" });

            AssertHelper.AssertList(new int[] { 0, 1, 2, 3, 4 }, result);
        }

        [Test]
        public void FindSubstringTest_WordsTooLong()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("barfoo", new string[] { "foo", "bar", "the" });

            AssertHelper.AssertList(new int[] { }, result);
        }

        [Test]
        public void FindSubstringTest_DuplicateWords()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "good" });

            AssertHelper.AssertList(new int[] { 8 }, result);
        }
    }
}
