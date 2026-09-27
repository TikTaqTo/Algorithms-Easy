using System.Runtime.InteropServices.JavaScript;

namespace Algorithms_Easy;

/// <summary>
/// 160. Intersection of Two Linked Lists
/// Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect.
/// If the two linked lists have no intersection at all, return null.
/// For example, the following two linked lists begin to intersect at node c1:
/// The test cases are generated such that there are no cycles anywhere in the entire linked structure.
/// Note that the linked lists must retain their original structure after the function returns.
/// Custom Judge:
/// The inputs to the judge are given as follows (your program is not given these inputs):
/// intersectVal - The value of the node where the intersection occurs. This is 0 if there is no intersected node.
/// listA - The first linked list.
/// listB - The second linked list.
/// skipA - The number of nodes to skip ahead in listA (starting from the head) to get to the intersected node.
/// skipB - The number of nodes to skip ahead in listB (starting from the head) to get to the intersected node.
/// The judge will then create the linked structure based on these inputs and pass the two heads, headA and headB to your program.
/// If you correctly return the intersected node, then your solution will be accepted.
/// </summary>
public class IntersectionOfTwoLinkedLists
{
    /// <summary>
    /// Standart(Базовое решение). Решение через 2 хранилища Stack и проходимся от конца к началу сравнивая каждый элемент.
    /// </summary>
    /// <param name="headA">[a1,a2,a3,c1,c2]</param>
    /// <param name="headB">[b1,b2,b3,c1,c2]</param>
    /// <returns>c1</returns>
    public ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB)
    {
        ListNode? result = null;
        var stackA = new Stack<ListNode>();
        var stackB = new Stack<ListNode>();

        while (headA != null)
        {
            stackA.Push(headA);
            headA = headA.next;
        }
        while (headB != null)
        {
            stackB.Push(headB);
            headB = headB.next;
        }

        while (stackA.Count > 0 && stackB.Count > 0 && ReferenceEquals(stackA.Peek(), stackB.Peek()))
        {
            result = stackA.Pop(); 
            stackB.Pop();
        }

        return result;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 хранилища Stack и проходимся от конца к началу сравнивая каждый элемент.
    /// </summary>
    /// <param name="headA">[a1,a2,a3,c1,c2]</param>
    /// <param name="headB">[b1,b2,b3,c1,c2]</param>
    /// <returns>c1</returns>
    public ListNode? GetIntersectionNodeBestSpeed(ListNode? headA, ListNode? headB)
    {
        ListNode? listA = headA;
        ListNode? listB = headB;

        while (listA != listB) {
            listA = listA != null ? listA.next : headB;
            listB = listB != null ? listB.next : headA;
        }

        return listA;
    }
    
    public class ListNode { 
        public int val;
        public ListNode? next;
        public ListNode (int val=0, ListNode? next=null) {
            this.val = val;
            this.next = next;
        }
    }
}