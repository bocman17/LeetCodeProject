using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _022_GenerateParentheses
    {
        public IList<string> GenerateParentheses(int n)
        {
            var result = new List<string>();
            if(n <= 0) return result;

            GenerateAndCheck("", n, n, result);

            return result;
        }

        private void GenerateAndCheck(string str, int open, int close, List<string> result)
        {
            if (open == 0 && close == 0)
            {
                result.Add(str);
                return;
            }
            if (open > 0)
            {
                GenerateAndCheck(str + "(", open - 1, close, result);
            }
            if (close > open)
            {
                GenerateAndCheck(str + ")", open, close - 1, result);
            }
        }
    }
}
