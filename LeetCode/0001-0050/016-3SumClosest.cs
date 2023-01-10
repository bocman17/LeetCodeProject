using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _016_3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int minNum = int.MaxValue;
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == target) { return sum; }
                    else
                    {
                        int currNum = Math.Abs(sum - target);
                        if (currNum < minNum)
                        {
                            result = sum;
                            minNum = currNum;
                        }
                        if (sum > target) right--;
                        else left++;
                    }
                }
            }
            return result;
        }
    }
}
