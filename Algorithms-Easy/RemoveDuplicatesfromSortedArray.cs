using System.ComponentModel.DataAnnotations;

namespace Algorithms_Easy;

/// <summary>
/// 26. Remove Duplicates from Sorted Array
/// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
/// The relative order of the elements should be kept the same.
/// Consider the number of unique elements in nums to be k. After removing duplicates, return the number of unique elements k.
/// The first k elements of nums should contain the unique numbers in sorted order. The remaining elements beyond index k - 1 can be ignored.
/// </summary>
public class RemoveDuplicatesfromSortedArray {
    /// <summary>
    /// Standart(Базовое решение). Решаем через временную переменную temp которая указывает на элемент массива для проверки на дубль и
    /// добавление в массив с уникальными значениями.
    /// </summary>
    /// <param name="nums">[1,1,2]</param>
    /// <returns>[1,2,_]</returns>
    public int RemoveDuplicates(int[] nums)
    {
        List<int> withoutDuplicates = new List<int>();
        int temp = nums[0];
        withoutDuplicates.Add(temp);
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (temp != nums[i])
            {
                withoutDuplicates.Add(nums[i]);
                temp = nums[i];
            }
        }

        for (int i = 0; i < withoutDuplicates.Count; i++)
        {
            nums[i] = withoutDuplicates[i];
        }
        
        return withoutDuplicates.Count;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Лучшее решение по скорости.
    /// </summary>
    /// <param name="nums">[1,1,2]</param>
    /// <returns>[1,2,_]</returns>
    public int RemoveDuplicatesBestSpeed(int[] nums)
    {
        if (nums.Length == 0) return 0;
        
        int k = 1;
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[k] = nums[i];
                k++;
            }
        }
        
        return k;
    }
}