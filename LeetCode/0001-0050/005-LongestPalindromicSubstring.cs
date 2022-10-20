using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _005_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1) return s;
            int charArrLen = s.Length * 2 + 1;
            char[] charArr = new char[charArrLen];
            for (int i = 0; i < s.Length; i++)
            {
                charArr[i * 2] = '#';
                charArr[i * 2 + 1] = s[i];
            }

            charArr[charArrLen - 1] = '#';
            int[] p = new int[charArrLen];
            int R = 0, C = 0, longestC = 0;

            for (int i = 1; i < charArrLen - 1; i++)
            {
                if (R > i)
                {
                    p[i] = Math.Min(p[C * 2 - i], R - i);
                }

                while (i - 1 - p[i] >= 0 && i + 1 + p[i] < charArrLen && charArr[i - 1 - p[i]] == charArr[i + 1 + p[i]])
                {
                    p[i]++;
                }

                if (i + p[i] > R)
                {
                    C = i;
                    R = i + p[i];
                }

                if (p[i] > p[longestC])
                {
                    longestC = i;
                }
            }
            int range = p[longestC];
            return s.Substring((longestC - range) / 2, range);
        }
    }
}
