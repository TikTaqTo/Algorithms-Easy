namespace Algorithms_Easy;

/// <summary>
/// 2465. Number of Distinct Averages
/// You are given a 0-indexed integer array nums of even length.
/// As long as nums is not empty, you must repetitively:
/// Find the minimum number in nums and remove it.
/// Calculate the average of the two removed numbers.
/// The average of two numbers a and b is (a + b) / 2.
/// For example, the average of 2 and 3 is (2 + 3) / 2 = 2.5.
/// Return the number of distinct averages calculated using the above process.
/// Note that when there is a tie for a minimum or maximum number, any can be removed.
/// </summary>
public class NumberOfDistinctAverages
{
    /// <summary>
    /// Standart(Базовое решение). Решение через HashSet структуру данных
    /// 1) Сортируем массив для постановки 2 указателей
    /// 2) Проверяем HashSet, если там есть дубль то не вносим среднее значение
    /// 3) Возвращаем в качестве результата колличество записей из HashSet
    /// </summary>
    /// <param name="nums">[4,1,4,0,3,5]</param>
    /// <returns>2</returns>
    public int DistinctAverages(int[] nums)
    {
        HashSet<int> results = new HashSet<int>();
        nums.Sort();

        for (int min = 0, max = nums.Length - 1; min < max; min++, max--)
        {
            int sum = (nums[min] + nums[max]) / 2;
            if(!results.Contains(sum))
                results.Add(sum);
        }

        return results.Count;
    }
}