using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _025_ReverseNodesInKGroup
    {
        public ListNode? ReverseKGroup(ListNode? head, int k)
        {
            if (k <= 1) return head;
            var queue = new Queue<ListNode>();
            var temp = head;
            while (queue.Count != k && head != null)
            {
                queue.Enqueue(head);
                head = head.next;
            }
            if (queue.Count != k)
            {
                return temp;
            }

            head = ReverseKGroup(head, k);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                node.next = head;
                head = node;
            }

            return head;
        }
    }
}
