namespace Algorithms_Easy;

/// <summary>
/// 21. Merge Two Sorted Lists
/// You are given the heads of two sorted linked lists list1 and list2.
/// Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
/// Return the head of the merged linked list.
/// </summary>
public class MergTwoSortedLists
{
    /// <summary>
    /// Standart(Базовое решение). Решаем через перебор и новый список mergedList адресов указателя.
    /// Можно было решить через изменения указателей уже существующих списков, условно менять указатели для list1, возвращать его в виде результата.
    /// </summary>
    /// <remarks></remarks>
    /// <param name="list1">[1,2,4]</param>
    /// <param name="list2">[1,3,4]</param>
    /// <returns>[1,1,2,3,4,4]</returns>
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2; 
        if (list2 == null) return list1;
        
        var mergedList = new ListNode(0, null);
        
        if (list1.val > list2.val)
        {
            mergedList.val = list2.val;
            mergedList.next = MergeTwoLists(list1, list2.next);
        }
        else if (list1.val <= list2.val)
        {
            mergedList.val = list1.val;
            mergedList.next = MergeTwoLists(list1.next, list2);
        }

        return mergedList;
    }
}

public class ListNode { 
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
    this.val = val;
    this.next = next;
    }
 }