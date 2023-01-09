using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _013_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var romanValues = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 },
            };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int currentVal = romanValues[s[i]];
                if ( i == s.Length - 1)
                {
                    result += romanValues[s[i]];
                }
                else
                {
                    int nextVal = romanValues[s[i + 1]];
                    if(currentVal < nextVal)
                    {
                        result -= currentVal;
                    }
                    else result += currentVal;
                }
            }
            return result;
        }
    }
}
