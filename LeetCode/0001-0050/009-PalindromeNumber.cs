using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _009_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string s = x.ToString();
            string reversed = String.Join("", s.Reverse());

            return s.Equals(reversed);
        }
    }
}
