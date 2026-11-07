namespace Algorithms_Easy;

/// <summary>
/// 2460. Apply Operations to an Array
/// You are given a 0-indexed array nums of size n consisting of non-negative integers.
/// You need to apply n - 1 operations to this array where, in the ith operation (0-indexed), you will apply the following on the ith element of nums:
/// If nums[i] == nums[i + 1], then multiply nums[i] by 2 and set nums[i + 1] to 0. Otherwise, you skip this operation.
/// After performing all the operations, shift all the 0's to the end of the array.
/// For example, the array [1,0,2,0,0,1] after shifting all its 0's to the end, is [1,2,1,0,0,0].
/// Return the resulting array.
/// Note that the operations are applied sequentially, not all at once.
/// </summary>
public class ApplyOperationsToAnArray
{
    /// <summary>
    /// Standart(Базовое решение). Решение через 2 указателя.
    /// 1) Проходимся и суммируем элементы массива
    /// 2) Сортируем их в порядке в начало цифры, конец нули
    /// </summary>
    /// <param name="nums">[1,2,2,1,1,0]</param> [1,4,0,2,0,0] => [1,4,2,0,0,0]
    /// <returns>[1,4,2,0,0,0]</returns>
    public int[] ApplyOperations(int[] nums)
    {
        int[] result = nums.ToArray();
        
        for (int i = 0, j = 1; j < result.Length; i++, j++)
        {
            if (result[i] == result[j])
            {
                result[i] += result[j];
                result[j] = 0;
            }
        }

        for (int i = 0, j = 1; j < result.Length;)
        {
            if (result[i] != 0)
                i++;

            if (j < result.Length && result[j] == 0 || i >= j)
                j++;

            if (j < result.Length && result[i] == 0 && result[j] != 0)
            {
                result[i] = result[j];
                result[j] = 0;
                i++;
                j++;
            }
        }
        
        return result;
    }
}