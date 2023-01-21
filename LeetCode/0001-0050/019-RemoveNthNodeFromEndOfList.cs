using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _019_RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthNodeFromEndOfList(ListNode head, int n)
        {
            if (head == null || n <= 0) return null;

            ListNode dummy = new ListNode(0, head);
            ListNode first = head;
            ListNode second = dummy;

            for (int i = 0; i < n; ++i)
            {
                if (first == null) return head;
                first = first.next;
            }

            while(first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;
            return dummy.next;
        }
    }
}
