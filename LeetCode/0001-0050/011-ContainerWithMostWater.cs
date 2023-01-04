using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _011_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int MaxArea = 0, i = 0, j = height.Length - 1;
            while (i < j)
            {
                MaxArea = Math.Max((j - i) * Math.Min(height[j], height[i]), MaxArea);
                (i, j) = height[j] < height[i] ? (i, j - 1) : (i + 1, j);
            }

            return MaxArea;
        }
    }
}
