using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _006_ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1 || s.Length <= 1) { return s; }

            var sb = new StringBuilder();

            for (int i = 0; i < numRows; i++)
            {
                int pos = i;
                bool flag = false;

                while (pos < s.Length)
                {

                    sb.Append(s[pos]);
                    if (flag && i != 0 || i == numRows - 1) pos += i * 2;
                    else pos += (numRows - i + numRows - i - 2);

                    flag = !flag;
                }
            }
            return sb.ToString();
        }
    }
}
