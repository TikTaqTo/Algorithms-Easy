namespace Algorithms_Easy;

/// <summary>
/// 977. Squares of a Sorted Array
/// Given an integer array nums sorted in non-decreasing order,
/// return an array of the squares of each number sorted in non-decreasing order.
/// </summary>
public class SquaresOfASortedArray
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 указателя
    /// 1) Так как массив уже отсортирован, мы знаем что максимальные значения находяться по краям массива
    /// 2) Если левый квадрат больше правого, заполняем левым значением и делаем шаг левым указателем
    /// 3) Если правый квадрат больше левого, заполняем правым значение и делаем шаг правым указателем
    /// 4) Используем новый массив  
    /// </summary>
    /// <param name="nums">[-5,-3,-2,-1]</param>
    /// <returns>[1,4,9,25]</returns>
    public int[] SortedSquares(int[] nums)
    {
        int[] result = new int[nums.Length];
        
        for (int i = 0, j = nums.Length - 1, c = result.Length - 1; i <= j; c--)
        {
            int left = nums[i] * nums[i];
            int right = nums[j] * nums[j];

            if (left > right)
            {
                result[c] = left;
                i++;
            }
            else
            {
                result[c] = right;
                j--;
            }
        }
        
        return result;
    } 
}