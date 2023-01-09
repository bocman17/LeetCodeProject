using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _014_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];

            string prefix = strs[0];

            for (int i = 0; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Remove(prefix.Length - 1);

                    if (prefix.Length == 0)
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }
    }
}
