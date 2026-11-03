namespace Algorithms_Easy;

/// <summary>
/// 2200. Find All K-Distant Indices in an Array
/// You are given a 0-indexed integer array nums and two integers key and k.
/// A k-distant index is an index i of nums for which there exists at least one index j such that |i - j| <= k and nums[j] == key.
/// Return a list of all k-distant indices sorted in increasing order.
/// </summary>
public class FindAllKDistantIndicesInAnArray
{
    /// <summary>
    /// Standart(Базовое решение). Решение через перебор и сортировку
    /// 1) Ищем ключи по массиву nums[], добавляем их в HashSet
    /// 2) Получаем значение из массива в пределах наших ключей
    /// 3) Сортируем и возвращаем результат
    /// </summary>
    /// <param name="nums">[3,4,9,1,3,9,5]</param>
    /// <param name="key">9</param>
    /// <param name="k">1</param>
    /// <returns>[1,2,3,4,5,6]</returns>
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        int n = nums.Length;
        HashSet<int> resultSet = new HashSet<int>();
        
        List<int> keyIndices = new List<int>();
        for (int j = 0; j < n; j++) 
        {
            if (nums[j] == key) {
                keyIndices.Add(j);
            }
        }
        
        foreach (int j in keyIndices) 
        {
            int start = Math.Max(0, j - k);
            int end = Math.Min(n - 1, j + k);
            
            for (int i = start; i <= end; i++) {
                resultSet.Add(i);
            }
        }
        
        List<int> result = resultSet.ToList();
        result.Sort();
        
        return result;
    }
}