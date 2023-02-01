using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _030_SubstringWithConcatenationOfAllWords
    {
        public IList<int> FindSubstring(string s, string[] words) // test
        {
            List<int> result = new();
            if(words.Length == 0) { return result; }
            int wordLength = words[0].Length;
            Dictionary<string, int> wordCount = words.GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());

            for (int offset = 0; offset < wordLength; offset++)
            {
                Queue<string> queue = new(words.Length + 1);
                int invalidCounter = 0;
                for (int i = 0; i < (s.Length - offset) / wordLength; i++)
                {
                    string word = s.Substring(offset + i * wordLength, wordLength);

                    if (wordCount.ContainsKey(word))
                    {
                        if (--wordCount[word] == -1)
                            invalidCounter++;
                        queue.Enqueue(word);
                    }
                    else
                    {
                        while (queue.Count > 0)
                            wordCount[queue.Dequeue()]++;
                        invalidCounter = 0;
                    }

                    if (queue.Count > words.Length)
                        if (++wordCount[queue.Dequeue()] == 0)
                            invalidCounter--;

                    if (invalidCounter == 0 && queue.Count == words.Length)
                        result.Add(offset + (i - words.Length + 1) * wordLength);
                }

                while (queue.Count > 0)
                    wordCount[queue.Dequeue()]++;
            }

            return result;
        }
    }
}
