using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _007_ReverseInteger
    {
        public int Reverse(int x)
        {
            long result = 0;
            while (x != 0)
            {
                result = (x % 10) + (result * 10);
                if (result > int.MaxValue || result < int.MinValue) return 0;
                x /= 10;
            }
            return (int)result;
        }
    }
}
