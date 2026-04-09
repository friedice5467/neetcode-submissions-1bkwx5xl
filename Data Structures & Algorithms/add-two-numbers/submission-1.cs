/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var dummy = new ListNode();
        var cur = dummy;

        int carry = 0;
        while(l1 != null || l2 != null || carry != 0)
        {
            int v1 = l1?.val ?? 0;
            int v2 = l2?.val ?? 0;

            int val = v1 + v2 + carry;
            carry = val / 10;
            val = val % 10;
            cur.next = new ListNode(val);

            cur = cur.next;
            l1 = l1?.next ?? null;
            l2 = l2?.next ?? null;
        }

        return dummy.next;
    }
}
