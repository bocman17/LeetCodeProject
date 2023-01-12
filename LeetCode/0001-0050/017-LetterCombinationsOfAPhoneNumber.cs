using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _017_LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombination(string digits)
        {
            List<string> result = new List<string>();
            digits = digits.Replace("1", "");
            if (digits == "") return result;

            Dictionary<char, string> combinations = new()
            {
                { '0', " " },
                { '1', "" },
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" },
            };

            Combination("", digits, 0, result, combinations);

            return result;
        }

        public void Combination(string pref, string digits, int index, List<string> result, Dictionary<char, string> combinations)
        {
            if (index >= digits.Length)
            {
                result.Add(pref);
                return;
            }

            String letters = combinations[digits[index]];
            for (int i = 0; i < letters.Length; i++)
            {

                Combination(pref + Convert.ToString(letters[i]), digits, index + 1, result, combinations);
            }
        }
    }
}
