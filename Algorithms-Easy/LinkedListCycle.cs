namespace Algorithms_Easy;


/// <summary>
/// 141. Linked List Cycle
/// Given head, the head of a linked list, determine if the linked list has a cycle in it.
/// There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
/// Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
/// Return true if there is a cycle in the linked list. Otherwise, return false.
/// </summary>
public class LinkedListCycle
{
    
    /// <summary>
    /// Standart(Базовое решение). Решение через 2 указателя, fast и slow, если они встречаются значит список цикличен.
    /// </summary>
    /// <param name="head">[1,2]</param>
    /// <returns>false</returns>
    public bool HasCycle(ListNode head) 
    {
        if (head == null || head.next == null)
            return false;
            
        ListNode slow = head;
        ListNode fast = head.next.next;

        while (fast != null && fast.next != null)
        {
            if (slow == fast)
                return true;
            
            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 указателя, fast и slow, если они встречаются значит список цикличен.
    /// </summary>
    /// <param name="head">[1,2]</param>
    /// <returns>false</returns>
    public bool HasCycleBestSpeed(ListNode head) 
    {
        ListNode slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast) return true;
        }
        return false;
    }
    
    public class ListNode {
         public int val;
             public ListNode next;
             public ListNode(int x) {
                 val = x;
                 next = null;
             }
     }
}