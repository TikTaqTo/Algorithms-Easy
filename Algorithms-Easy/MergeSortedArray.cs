namespace Algorithms_Easy;

/// <summary>
/// 88. Merge Sorted Array
/// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
/// and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
/// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
/// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
/// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
/// and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
/// Follow up: Can you come up with an algorithm that runs in O(m + n) time?
/// </summary>
public class MergeSortedArray
{
    
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решаем через 3 указателя firstPointer,secondPointer и resultPointer.
    /// firstPointer - указывает на nums1[m-1] = 3 массива, максимальное значение которое есть в массиве nums1
    /// secondPointer - указывает на nums2[n-1] = 6 массива, максимальное значение которое есть в массиве nums2
    /// resultPointer - указывает на nums1[m+n-1] = 0 массива, сюда мы будем записывать максимальное значение которое есть в 2 массивах.
    /// </summary>
    /// <param name="nums1">[1,2,3,0,0,0]</param>
    /// <param name="m">3</param>
    /// <param name="nums2">[2,5,6]</param>
    /// <param name="n">3</param>
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int firstPointer = m - 1;
        int secondPointer = n - 1;
        
        for (int resultPointer = m + n - 1; secondPointer >= 0; resultPointer--)
        {
            if (firstPointer >= 0 && nums1[firstPointer] > nums2[secondPointer])
            {
                nums1[resultPointer] = nums1[firstPointer];
                firstPointer--;
            }
            else
            {
                nums1[resultPointer] = nums2[secondPointer];
                secondPointer--;
            }
        }
    }
}