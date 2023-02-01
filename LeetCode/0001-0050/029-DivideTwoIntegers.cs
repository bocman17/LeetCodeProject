using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _029_DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            bool negative = false;
            uint udividend, udivisor;
            if (dividend == int.MinValue)
            {
                udividend = (uint)int.MaxValue + 1;
                negative = !negative;
            }
            else if (dividend < 0)
            {
                negative = !negative;
                udividend = (uint)-dividend;
            }
            else
                udividend = (uint)dividend;
            if (divisor == int.MinValue)
            {
                return dividend == int.MinValue ? 1 : 0;
            }
            else if (divisor < 0)
            {
                negative = !negative;
                udivisor = (uint)-divisor;
            }
            else
                udivisor = (uint)divisor;
            uint originalDivisor = udivisor;
            uint result = 0;
            while (udivisor <= (udividend >> 1))
                udivisor <<= 1;
            while (udivisor >= originalDivisor)
            {
                result <<= 1;
                if (udividend >= udivisor)
                {
                    udividend -= udivisor;
                    result++;
                }
                udivisor >>= 1;
            }
            return negative ? (int)-result : result <= int.MaxValue ? (int)result : int.MaxValue;
        }
    }
}
