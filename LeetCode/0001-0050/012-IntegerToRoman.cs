using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _012_IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var result = new StringBuilder();
            Dictionary<int, string> intRoman = new()
        {
            { 1000, "M"},
            { 900, "CM" },
            { 500, "D"},
            { 400, "CD"},
            { 100, "C" },
            { 90, "XC"},
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

            while (num > 0)
            {
                result.Append(intRoman.FirstOrDefault(x => x.Key <= num).Value);
                num -= intRoman.FirstOrDefault(x => x.Key <= num).Key;
            }

            return result.ToString();
        }
    }
}
