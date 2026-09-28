namespace Algorithms_Easy;

/// <summary>
/// 234. Palindrome Linked List
/// Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
/// </summary>
public class PalindromeLinkedList
{
    /// <summary>
    /// Standart(Базовое решение). Решаем через перевод в другую структуру данных, которой удобнее управлять а именно в масив.
    /// </summary>
    /// <remarks> Время: O(n) и Память: O(n) </remarks>
    /// <param name="head">[1,2,2,1]</param>
    /// <returns>true</returns>
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
            return true;

        var values = new List<int>();
        var current = head;

        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }

        int left = 0;
        int right = values.Count - 1;

        while (left < right)
        {
            if (values[left] != values[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решачем через 2 указателя, быстрый и медленный что бы найти середину палиндрома.
    /// 1) Находим середину палиндрома при помощи: Fast и Slow указателей.
    /// 2) Со середины мы меняем местами элементы односвязного списка.
    /// </summary>
    /// <param name="head">[1,2,2,1]</param>
    /// <returns>true</returns>
    public bool IsPalindromeBestSpeed(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode previous = null;

        while (slow != null)
        {
            ListNode nextNode = slow.next;

            slow.next = previous;
            previous = slow;

            slow = nextNode;
        }

        ListNode left = head;
        ListNode right = previous;

        while (right != null)
        {
            if (left.val != right.val)
            {
                return false;
            }

            left = left.next;
            right = right.next;
        }

        return true;
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