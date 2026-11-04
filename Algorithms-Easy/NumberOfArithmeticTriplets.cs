namespace Algorithms_Easy;

/// <summary>
/// 2367. Number of Arithmetic Triplets
/// You are given a 0-indexed, strictly increasing integer array nums and a positive integer diff.
/// A triplet (i, j, k) is an arithmetic triplet if the following conditions are met:
/// i &lt; j &lt; k,
/// nums[j] - nums[i] == diff, and
/// nums[k] - nums[j] == diff.
/// Return the number of unique arithmetic triplets.
/// </summary>
public class NumberOfArithmeticTriplets
{
    /// <summary>
    /// Standart(Базовое решение). Решение через HashSet структуру данных
    /// 1) Мы знаем что элементы не повторяются, из за чего доавбялем их в HashSet
    /// 2) После проверяем что он соответсвует условию из описание задачи
    /// </summary>
    /// <param name="nums">[0,1,4,6,7,10]</param>
    /// <param name="diff">3</param>
    /// <returns>2</returns>
    public int ArithmeticTriplets(int[] nums, int diff) 
    {
        HashSet<int> set = new HashSet<int>(nums);
        int count = 0;

        foreach (int num in nums) {
            if (set.Contains(num + diff) && set.Contains(num + 2 * diff))
                count++;
        }

        return count;
    }
    
    
}