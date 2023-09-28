using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nick_white_leetcode.ReverseLinkedList;

namespace nick_white_leetcode;

public class PalindromeLinkedList
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        slow = Reverse(slow);
        fast = head;

        while (slow != null)
        {
            if (slow.val != fast.val)
            {
                return false;
            }

            slow = slow.next;
            fast = fast.next;
        }

        return true;
    }

    private static ListNode Reverse(ListNode head)
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
