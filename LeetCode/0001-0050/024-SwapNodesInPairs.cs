using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _024_SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode? head) 
        {
            if (head == null || head.next == null) return head;

            ListNode second = head.next;
            head.next = second.next;
            second.next = head;

            head.next = SwapPairs(head.next);

            return second;
        }
    }
}
