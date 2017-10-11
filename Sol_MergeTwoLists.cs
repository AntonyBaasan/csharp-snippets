using System;

namespace csharp_snippets
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Sol_MergeTwoLists
    {
        public void Test()
        {
            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            var n3 = new ListNode(3);
            var n4 = new ListNode(4);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;

            var n5 = new ListNode(5);
            var n6 = new ListNode(6);
            var n7 = new ListNode(7);
            var n8 = new ListNode(8);
            n5.next = n6;
            n6.next = n7;
            n7.next = n8;

            var newList = MergeTwoLists(n1, n5);
            var n = newList;
            while (n != null)
            {
                Console.Write(n.val + " - ");
                n = n.next;
            }
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode start = new ListNode(-1);
            ListNode curr = start;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    curr.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    curr.next = l2;
                    l2 = l2.next;
                }
                curr = curr.next;
            }
            curr.next = l1 == null ? l2 : l1;

            return start.next;
        }
    }
}