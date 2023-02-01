using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _028_ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            int length = needle.Length;

            for (int i = 0; i <= haystack.Length - length; i++)
            {
                if (haystack.Substring(i, length) == needle) { return i; }
            }

            return -1;

            //return haystack.IndexOf(needle);
        }
    }
}
