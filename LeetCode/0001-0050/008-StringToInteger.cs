using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _008_StringToInteger
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            if (s.Length == 0)
                return 0;
            if (!char.IsDigit(s[0]) && s[0] != '+' && s[0] != '-')
                return 0;
            long result = 0;
            int sign = 1;
            if (s[0] == '-')
                sign = -1;
            else if (s[0] >= '0' && s[0] <= '9')
                result = s[0] - '0';
            for (int i = 1; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    break;
                }
                result = (result * 10) + (s[i] - '0');
                if (sign * result < int.MinValue)
                    return int.MinValue;
                if (sign * result > int.MaxValue)
                    return int.MaxValue;
            }
            return (int)(sign * result);
        }
    }
}
