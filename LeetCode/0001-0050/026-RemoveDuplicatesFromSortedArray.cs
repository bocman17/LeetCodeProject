using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _026_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;
            int l = 1;
            for (int r = 1; r < nums.Length; r++)
            {
                if (nums[r] != nums[r - 1])
                {
                    nums[l] = nums[r];
                    l++;
                }
            }

            return l;

            //var distinct = nums.Distinct();
            //int k = 0;
            //foreach (var num in distinct)
            //{
            //	nums[k] = num;
            //	k++;
            //}

            //return k;
        }
    }
}
