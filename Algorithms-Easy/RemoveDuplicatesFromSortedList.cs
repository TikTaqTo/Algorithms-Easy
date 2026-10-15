namespace Algorithms_Easy;

/// <summary>
/// 83. Remove Duplicates from Sorted List
/// Given the head of a sorted linked list, delete all duplicates such that each element appears only once.
/// Return the linked list sorted as well.
/// </summary>
public class RemoveDuplicatesFromSortedList
{
    /// <summary>
    /// Standart(Базовое решение). Решение через пропуск дубликатов и перенос указателей
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode current = head;

        while (current.next != null)
        {
            if (current.val == current.next.val)
            {
                // Skip the duplicate node
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
        return head;
    }
    
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val;
            this.next = next;
        }
    }
}