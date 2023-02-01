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
    public class _028_ImplementStrStr_Test
    {
        [Test]
        public void StrStrTest()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("abcdefg", "bcd");

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void StrStrTest_EmptyNeedle()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("abcdefg", "");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void StrStrTest_NeedleLongerThanRest()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("abcdefg", "gh");

            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void StrStrTest_SingleCharacterNeedle()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("abcdefg", "b");

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void StrStrTest_JumpCheck()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("mississippi", "issip");

            Assert.That(result, Is.EqualTo(4));
        }
    }
}
