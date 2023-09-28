using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nick_white_leetcode;

public class ReverseLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode ReverseList(ListNode head)
    {
        ListNode previous = null;
        ListNode next = null;

        while (head != null)
        {
            next = head.next;
            head.next = previous;
            previous = head;
            head = next;
        }

        return previous;
    }
}
