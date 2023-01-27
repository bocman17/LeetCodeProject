using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _021_MergeTwoSortedLists
    {
        public ListNode MergeTwoSortedLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1.val < list2.val)
            {
                list1.next = MergeTwoSortedLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoSortedLists(list2.next, list1);
                return list2;
            }
        }
    }
}
