using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _003_LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(string.IsNullOrEmpty(s)) return 0;

            HashSet<char> set = new HashSet<char>();
            Queue<char> queue = new Queue<char>();
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(s[i]))
                {
                    while (queue.Count > 0 && set.Contains(s[i]))
                    {
                        char currentChar = queue.Dequeue();
                        set.Remove(currentChar);
                    }
                }

                set.Add(s[i]);
                queue.Enqueue(s[i]);
                int currentLength = queue.Count;
                maxLength = currentLength > maxLength ? currentLength : maxLength; 
            }

            return maxLength;
        }
    }
}
