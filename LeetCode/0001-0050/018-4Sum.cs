using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _018_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            List<int> quad = new List<int>();

            KSum(4, 0, target, nums, quad, result);
            return result;
        }

        private void KSum(int k, int start, long target, int[] nums, List<int> quad, IList<IList<int>> result)
        {
            if (k > 2)
            {
                for (int i = start; i < nums.Length - k + 1; i++)
                {
                    if (i > start && nums[i] == nums[i - 1])
                    {
                        continue;
                    }
                    quad.Add(nums[i]);
                    KSum(k - 1, i + 1, target - nums[i], nums, quad, result);
                    quad.RemoveAt(quad.Count - 1);
                }
            }
            else
            {
                int l = start;
                int r = nums.Length - 1;
                while (l < r)
                {
                    int sum = nums[l] + nums[r];
                    if (sum < target)
                    {
                        l++;
                    }
                    else if (sum > target)
                    {
                        r--;
                    }
                    else
                    {
                        var temp = new List<int>(quad);
                        temp.Add(nums[l]);
                        temp.Add(nums[r]);
                        result.Add(temp);
                        l++;
                        while (l < r && nums[l] == nums[l - 1]) l++;
                    }
                }
            }
        }
    }
}
