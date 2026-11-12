namespace Algorithms_Easy;

/// <summary>
/// 2562. Find the Array Concatenation Value
/// You are given a 0-indexed integer array nums.
/// The concatenation of two numbers is the number formed by concatenating their numerals.
/// For example, the concatenation of 15, 49 is 1549.
/// The concatenation value of nums is initially equal to 0. Perform this operation until nums becomes empty:
/// If nums has a size greater than one, add the value of the concatenation of the first and the last element to the concatenation
/// value of nums, and remove those two elements from nums. For example, if the nums was [1, 2, 4, 5, 6], add 16 to the concatenation value.
/// If only one element exists in nums, add its value to the concatenation value of nums, then remove it.
/// eturn the concatenation value of nums.
/// </summary>
public class FindTheArrayConcatenationValue
{
    /// <summary>
    /// Standart(Базовое решение). Решаем через 2 указателя
    /// 1) Проверка на нечётное колличество чисел в nums, добавление среднего элемента nums[nums.Length / 2]
    /// 2) Ставим указатели в начало и конец массива, двигаем на встречу друг другу и подсчитываем сумму
    /// </summary>
    /// <remarks>Convert.ToInt64(temp) - на всякий случай, только потом увидел что в условиях: 1 &lt;= nums[i] &lt;= 10^4 </remarks>
    /// <param name="nums">[7,52,2,4]</param>
    /// <returns>596</returns>
    public long FindTheArrayConcVal(int[] nums)
    {
        long result = 0;
        
        if (nums.Length % 2 != 0)
            result += nums[nums.Length / 2];
        
        for (int i = 0, j = nums.Length - 1; i < j; i++, j--)
        {
            string temp = nums[i].ToString() + nums[j];
            result += Convert.ToInt64(temp);
        }
        
        return result;
    }
}