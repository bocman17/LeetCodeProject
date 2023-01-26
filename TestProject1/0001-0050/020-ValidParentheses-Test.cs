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
    public class _020_ValidParentheses_Test
    {
        [Test]
        public void IsValidTest()
        {
            var solution = new _020_ValidParentheses();
            Assert.Multiple(() =>
            {
                Assert.That(solution.IsValid("()"), Is.True);
                Assert.That(solution.IsValid("[]"), Is.True);
                Assert.That(solution.IsValid("{}"), Is.True);
                Assert.That(solution.IsValid("()[]{}"), Is.True);
            });
        }

        [Test]
        public void IsValidTest_NotValid()
        {
            var solution = new _020_ValidParentheses();
            Assert.Multiple(() =>
            {
                Assert.That(solution.IsValid("("), Is.False);
                Assert.That(solution.IsValid(")"), Is.False);
                Assert.That(solution.IsValid("["), Is.False);
                Assert.That(solution.IsValid("]"), Is.False);
                Assert.That(solution.IsValid("{"), Is.False);
                Assert.That(solution.IsValid("}"), Is.False);
                Assert.That(solution.IsValid("(]"), Is.False);
                Assert.That(solution.IsValid("(}"), Is.False);
                Assert.That(solution.IsValid("[)"), Is.False);
                Assert.That(solution.IsValid("[}"), Is.False);
                Assert.That(solution.IsValid("{)"), Is.False);
                Assert.That(solution.IsValid("{]"), Is.False);
                Assert.That(solution.IsValid("{]"), Is.False);
                Assert.That(solution.IsValid("{((())})"), Is.False);
            });
        }
    }
}
