using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {   
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    return new int[] { dic[nums[i]], i };
                }
                else
                {
                    dic[target - nums[i]] = i;
                }
            }

            return new int[] { };
        }
    }
}
