namespace Algorithms_Easy;

/// <summary>
/// 905. Sort Array By Parity
/// Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
/// Return any array that satisfies this condition.
/// </summary>
public class SortArrayByParity
{
    /// <summary>
    /// Standart(Базовое решение). Решение через 2 указателя
    /// 1) i идёт с начала массива и ищет первый нечётный символ
    /// 2) j идёт с конца массива и ищет первый чётный символ
    /// 3) меняет местами i и j
    /// </summary>
    /// <param name="nums">[1,3,4,2]</param>
    /// <returns>[2,4,3,1]</returns>
    public int[] SortArrayByParityAnswer(int[] nums) 
    {
        for (int i = 0, j = nums.Length - 1; i < j;)
        {
            if (nums[i] % 2 != 0 && nums[j] % 2 == 0)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
                j--;
            }
            else
            {
                if (nums[i] % 2 == 0) 
                    i++;
                
                if (nums[j] % 2 != 0) 
                    j--;
            }
        }

        return nums;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через новый массив и перебор элементов
    /// 1) Ищем чётные числа что бы добавлять их в начало через left
    /// 2) Ищем нечётные числа что бы добавлять их в конец через right 
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortArrayByParityBestSpeed(int[] nums) {
        int[] res = new int[nums.Length];
        int left =0;
        int right = nums.Length-1;
        foreach(int i in nums){
            if (i%2==0){
                res[left] = i;
                left++;
            }
            else{
                res[right] = i;
                right--;
            }
        }
        return res;
    }
}