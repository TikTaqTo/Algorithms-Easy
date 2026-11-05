namespace Algorithms_Easy;

/// <summary>
/// 2441. Largest Positive Integer That Exists With Its Negative
/// Given an integer array nums that does not contain any zeros, find the largest positive integer k such that -k also exists in the array.
/// Return the positive integer k. If there is no such integer, return -1.
/// </summary>
public class LargestPositiveIntegerThatExistsWithItsNegative
{
    /// <summary>
    /// Standart(Базовое решение). Решение через тип данных Hash.
    /// 1) Так как числа не повторяются мы можем добавить их в Set
    /// 2) Проверяем подходит ли num по условиям задачи
    /// </summary>
    /// <param name="nums">[-1,2,-3,3]</param>
    /// <returns>3</returns>
    public int FindMaxK(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        
        var sortedNums = nums.OrderByDescending(x => x);
        
        foreach (int num in sortedNums) {
            if (num > 0 && set.Contains(-num)) 
                return num;
        }
        
        return -1;
    }
}