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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var nodes = new List<ListNode>();
        var curr = head;
        while(curr != null)
        {
            nodes.Add(curr);
            curr = curr.next;
        }

        var index = nodes.Count - n;

        if(index == 0)
        {
            head = head.next;
        }
        else{
            var prev = nodes[index - 1];
            prev.next = prev.next.next;
        }
        return head;
    }
}
