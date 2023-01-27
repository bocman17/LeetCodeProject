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
    public class _022_GenerateParentheses_Test
    {
        [Test]
        public void Test()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParentheses(3);

            Assert.That(result, Has.Count.EqualTo(5));
            Assert.Multiple(() =>
            {
                Assert.That(result[0], Is.EqualTo("((()))"));
                Assert.That(result[1], Is.EqualTo("(()())"));
                Assert.That(result[2], Is.EqualTo("(())()"));
                Assert.That(result[3], Is.EqualTo("()(())"));
                Assert.That(result[4], Is.EqualTo("()()()"));
            });
        }

        [Test]
        public void GenerateParenthesisTest_NLessThanZero()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParentheses(-1);

            Assert.That(result, Has.Count.EqualTo(0));
        }

        [Test]
        public void GenerateParenthesisTest_NEqualZero()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParentheses(0);

            Assert.That(result, Has.Count.EqualTo(0));
        }

        [Test]
        public void GenerateParenthesisTest_NEqualOne()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParentheses(1);

            Assert.That(result, Has.Count.EqualTo(1));
            Assert.That(result[0], Is.EqualTo("()"));
        }

        [Test]
        public void GenerateParenthesisTest_LargeN()
        {
            var solution = new _022_GenerateParentheses();

            var result = solution.GenerateParentheses(4);
            Assert.That(result, Has.Count.EqualTo(14));

            result = solution.GenerateParentheses(5);
            Assert.That(result, Has.Count.EqualTo(42));

            result = solution.GenerateParentheses(6);
            Assert.That(result, Has.Count.EqualTo(132));
        }
    }
}
