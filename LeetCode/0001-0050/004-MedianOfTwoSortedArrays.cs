using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _004_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;

            if (m > n) return FindMedianSortedArrays(nums2, nums1);

            int start = 0, end = m;
            while (start <= end)
            {
                int i = (start + end) / 2;
                int j = (m + n + 1) / 2 - i;

                int ALeft = (i == 0) ? Int32.MinValue : nums1[i - 1];
                int ARight = (i == m) ? Int32.MaxValue : nums1[i];
                int BLeft = (j == 0) ? Int32.MinValue : nums2[j - 1];
                int BRight = (j == n) ? Int32.MaxValue : nums2[j];

                if (ALeft <= BRight && BLeft <= ARight)
                {
                    if ((m + n) % 2 == 0)
                    {
                        return (Math.Max(ALeft, BLeft) + Math.Min(ARight, BRight)) / 2.0;
                    }
                    return Math.Max(ALeft, BLeft);
                }
                else if (ALeft > BRight) end = i - 1;
                else start = i + 1;
            }
            return 0d;
        }
    }
}
