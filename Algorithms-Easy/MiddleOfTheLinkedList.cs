namespace Algorithms_Easy;

/// <summary>
/// 876. Middle of the Linked List
/// Given the head of a singly linked list, return the middle node of the linked list.
/// If there are two middle nodes, return the second middle node.
/// </summary>
public class MiddleOfTheLinkedList
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 указателя по классическому паттерну
    /// 1) Быстрый указатель успевает сделать 2 шага по этому он доберёться до конца раньше чем медленный указатель
    /// 2) Медленный указатель делает 1 шаг, половину шага быстрого указателя за счёт чего всегда будет находиться в центре 
    /// </summary>
    /// <param name="head">[1,2,3,4,5]</param>
    /// <returns>[3]</returns>
    public ListNode MiddleNode(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;
        
        while (fast != null && fast.next != null)
        {
            slow = slow?.next;
            fast = fast.next.next;
        }
    
        return slow;
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