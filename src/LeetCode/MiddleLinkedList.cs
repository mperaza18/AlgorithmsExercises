// Find the middle node of a linked list.
//
// Input: head = [0,1,2,3,4]
// Output: Node with value 2
// Explanation: The middle node of the list is node 2 (0-indexed).
// 
// If the number of nodes is even, then return the second middle node.
//// Input: head = [0,1,2,3,4,5]
// Output: Node with value 3
// Explanation: Since the list has two middle nodes with values 2 and 3, we return the second one.

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class MiddleLinkedList
{
    public ListNode Execute(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}