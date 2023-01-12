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
    public class _017_LetterCombinationsOfAPhoneNumber_Test
    {
        [Test]
        public void LetterCombinationsTest()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombination("23");

            Assert.That(result, Has.Count.EqualTo(9));
            Assert.That(result, Contains.Item("ad"));
            Assert.That(result, Contains.Item("ae"));
            Assert.That(result, Contains.Item("af"));
            Assert.That(result, Contains.Item("bd"));
            Assert.That(result, Contains.Item("be"));
            Assert.That(result, Contains.Item("bf"));
            Assert.That(result, Contains.Item("cd"));
            Assert.That(result, Contains.Item("ce"));
            Assert.That(result, Contains.Item("cf"));
        }

        [Test]
        public void LetterCombinationsTest_2()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombination("234");

            Assert.That(result, Has.Count.EqualTo(27));
        }

        [Test]
        public void LetterCombinationsTest_EmptyString()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombination("");

            Assert.That(result, Has.Count.EqualTo(0));
        }

        [Test]
        public void LetterCombinationsTest_WithZero()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombination("20");

            Assert.That(result, Has.Count.EqualTo(3));
            Assert.That(result, Contains.Item("a "));
            Assert.That(result, Contains.Item("b "));
            Assert.That(result, Contains.Item("c "));
        }

        [Test]
        public void LetterCombinationsTest_OnlyHaveZero()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombination("0000");

            Assert.That(result, Has.Count.EqualTo(1));
            Assert.That(result, Contains.Item("    "));
        }

        [Test]
        public void LetterCombinationsTest_WithOne()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();

            var result = solution.LetterCombination("21");
            Assert.That(result, Has.Count.EqualTo(3));
            Assert.That(result, Contains.Item("a"));
            Assert.That(result, Contains.Item("b"));
            Assert.That(result, Contains.Item("c"));

            result = solution.LetterCombination("213");
            Assert.That(result, Has.Count.EqualTo(9));
            Assert.That(result, Contains.Item("ad"));
            Assert.That(result, Contains.Item("ae"));
            Assert.That(result, Contains.Item("af"));
            Assert.That(result, Contains.Item("bd"));
            Assert.That(result, Contains.Item("be"));
            Assert.That(result, Contains.Item("bf"));
            Assert.That(result, Contains.Item("cd"));
            Assert.That(result, Contains.Item("ce"));
            Assert.That(result, Contains.Item("cf"));
        }

        [Test]
        public void LetterCombinationsTest_OnlyHaveOne()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombination("111");

            Assert.That(result, Has.Count.EqualTo(0));
        }

        [Test]
        public void LetterCombinationsTest_WithSeven()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombination("27");

            Assert.That(result, Has.Count.EqualTo(12));
            Assert.That(result, Contains.Item("ap"));
            Assert.That(result, Contains.Item("aq"));
            Assert.That(result, Contains.Item("ar"));
            Assert.That(result, Contains.Item("as"));
            Assert.That(result, Contains.Item("bp"));
            Assert.That(result, Contains.Item("bq"));
            Assert.That(result, Contains.Item("br"));
            Assert.That(result, Contains.Item("bs"));
            Assert.That(result, Contains.Item("cp"));
            Assert.That(result, Contains.Item("cq"));
            Assert.That(result, Contains.Item("cr"));
            Assert.That(result, Contains.Item("cs"));
        }

        [Test]
        public void LetterCombinationsTest_WithNine()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombination("9");

            Assert.That(result, Has.Count.EqualTo(4));
            Assert.That(result, Contains.Item("w"));
            Assert.That(result, Contains.Item("x"));
            Assert.That(result, Contains.Item("y"));
            Assert.That(result, Contains.Item("z"));

            result = solution.LetterCombination("29");

            Assert.That(result, Has.Count.EqualTo(12));
            Assert.That(result, Contains.Item("aw"));
            Assert.That(result, Contains.Item("ax"));
            Assert.That(result, Contains.Item("ay"));
            Assert.That(result, Contains.Item("az"));
            Assert.That(result, Contains.Item("bw"));
            Assert.That(result, Contains.Item("bx"));
            Assert.That(result, Contains.Item("by"));
            Assert.That(result, Contains.Item("bz"));
            Assert.That(result, Contains.Item("cw"));
            Assert.That(result, Contains.Item("cx"));
            Assert.That(result, Contains.Item("cy"));
            Assert.That(result, Contains.Item("cz"));
        }
    }
}
