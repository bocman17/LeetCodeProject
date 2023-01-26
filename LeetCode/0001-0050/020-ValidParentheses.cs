using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(')');
                    continue;
                }
                else if (c == '[')
                {
                    stack.Push(']');
                    continue;
                }
                else if (c == '{')
                {
                    stack.Push('}');
                    continue;
                }

                else if (stack.Count == 0 || c != stack.Pop())
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
