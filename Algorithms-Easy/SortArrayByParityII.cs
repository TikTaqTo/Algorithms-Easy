using System.Reflection;

namespace Algorithms_Easy;

/// <summary>
/// 922. Sort Array By Parity II
/// Given an array of integers nums, half of the integers in nums are odd, and the other half are even.
/// Sort the array so that whenever nums[i] is odd, i is odd, and whenever nums[i] is even, i is even.
/// Return any answer array that satisfies this condition.
/// </summary>
public class SortArrayByParityII
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 указателя, задача похожа на 917. Reverse Only Letters
    /// 1) Ставим 2 указателя: evenPointer - чётные, oddPointer - нечётные.
    /// 2) Ходим по элементами массива и проверям их соответсвие, если они соответсвуют идём дальше.
    /// 3) При несоответсвий evenPointer мы пропускаем шаг и проверяем всё ли хорошо с oddPointer если и тут не хорошо меняем местами.
    /// </summary>
    /// <param name="nums">[5,7,4,2]</param>
    /// <returns>[2,5,4,7]</returns>
    public int[] SortArrayByParityIIAnswer(int[] nums)
    {
        for (int evenPointer = 0, oddPointer = 1; evenPointer < nums.Length && oddPointer < nums.Length;)
        {
            if (nums[evenPointer] % 2 == 0)
            {
                evenPointer += 2;
            }
            else if (nums[oddPointer] % 2 == 1)
            {
                oddPointer += 2;
            }
            else
            {
                (nums[evenPointer], nums[oddPointer]) = (nums[oddPointer], nums[evenPointer]);

                evenPointer += 2;
                oddPointer += 2;
            }
        }

        return nums;
    }
}