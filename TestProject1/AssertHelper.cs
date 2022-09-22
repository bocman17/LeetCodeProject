using NUnit.Framework;

namespace LeetCode.Test
{
    public class AssertHelper
    {
        public static void AssertLinkList(int[] expected, ListNode actual)
        {
            Assert.Multiple(() =>
            {
                Assert.That(actual, Is.Not.Null);
                Assert.That(expected, Is.Not.Null);
                Assert.That(expected, Is.Not.Empty);
            });

            var current = actual;

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Multiple(() =>
                {
                    Assert.That(current, Is.Not.Null);
                    Assert.That(expected[i], Is.EqualTo(current.val));
                });
                current = current.next;
            }
            Assert.That(current, Is.Null);
        }

        public static void AssertArray<T>(T[] expected, T[] actual, bool ignoreLength = false)
        {
            if(!ignoreLength)
            {
                Assert.That(expected, Has.Length.EqualTo(actual.Length), message: "length is not a match");
            }

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(expected[i], Is.EqualTo(actual[i]), message: $"i {i} is not a match");
            }
        }

        public static void AssertArray<T>(T[,] expected, T[,] actual)
        {
            var rowCount = expected.GetLength(0);
            var colCount = expected.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Assert.That(expected[i, j], Is.EqualTo(actual[i, j]), message: $"i {i}, j {j} is not a match");
                }
            }
        }

        public static void AssertArray<T>(T[][] expected, T[][] actual)
        {
            Assert.That(expected, Has.Length.EqualTo(actual.Length), message: "length is not a match");

            var rowCount = expected.Length;
            var colCount = expected[0].Length;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Assert.That(expected[i][j], Is.EqualTo(actual[i][j]), message: $"i {i}, j {j} is not a match");
                }
            }
        }

        public static void AssertList<T>(T[] expected, IList<T> actual)
        {
            Assert.That(expected, Has.Length.EqualTo(actual.Count), message: "length is not a match");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(expected[i], Is.EqualTo(actual[i]), message: $"i {i} is not a match");
            }
        }

        public static void AssertList<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            Assert.That(expected, Has.Count.EqualTo(actual), message: "length is not a match");

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.That(expected[i], Has.Count.EqualTo(actual[i]), message: $"row {i} length is not a match");
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.That(expected[i][j], Is.EqualTo(actual[i][j]), message: $"i {i}, j {j} length is not a match");
                }
            }
        }

        public static void AssertMatrix(int[,] expected, int[,] actual)
        {
            Assert.Multiple(() =>
            {
                Assert.That(expected, Has.Length.EqualTo(actual), message: "length is not a match");
                Assert.That(expected.GetLength(0), Is.EqualTo(actual.GetLength(0)), message: "first axis length is not a match");
                Assert.That(expected.GetLength(1), Is.EqualTo(actual.GetLength(1)), message: "second axis length is not a match");
            });

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.That(expected[i, j], Is.EqualTo(actual[i, j]));
                }
            }
        }

        public static void AssertTree(TreeNode expected, TreeNode actual)
        {
            if (expected == null) Assert.That(actual, Is.Null);

            var stack1 = new Stack<TreeNode>();
            stack1.Push(expected);
            var stack2 = new Stack<TreeNode>();
            stack2.Push(actual);

            while(stack1.Count > 0 && stack2.Count > 0)
            {
                var cur1 = stack1.Pop();
                var cur2 = stack2.Pop();

                Assert.That(cur1.val, Is.EqualTo(cur2.val));
                if(cur1.left == null)
                {
                    Assert.That(cur2.left, Is.Null);
                }
                else
                {
                    stack1.Push(cur1.left);
                    stack2.Push(cur2.left);
                }
                if(cur1.right == null)
                {
                    Assert.That(cur2.right, Is.Null);
                }
                else
                {
                    stack1.Push(cur1.right);
                    stack2.Push(cur2.right);
                }
            }

            Assert.Multiple(() =>
            {
                Assert.That(stack1, Is.Empty);
                Assert.That(stack2, Is.Empty);
            });
        }

        public static void AssertTrees(IList<TreeNode> expected, IList<TreeNode> actual)
        {
            Assert.That(expected, Has.Count.EqualTo(actual), "count does not match");
            for (int i = 0; i < expected.Count; i++)
            {
                AssertTree(expected[i], actual[i]);
            }
        }
    }
}
