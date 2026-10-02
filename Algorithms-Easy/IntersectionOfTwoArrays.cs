namespace Algorithms_Easy;

/// <summary>
/// 349. Intersection of Two Arrays
/// Given two integer arrays nums1 and nums2, return an array of their intersection.
/// Each element in the result must be unique and you may return the result in any order.
/// </summary>
public class IntersectionOfTwoArrays
{
    /// <summary>
    /// Standart(Базовое решение). Решаем через 2 указателя, брутфорсом проходимся по каждому элементу.
    /// </summary>
    /// <param name="nums1">[2,1]</param>
    /// <param name="nums2">[1,2]</param>
    /// <returns>[1,2]</returns>
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j] && !result.Contains(nums1[i]))
                {
                    result.Add(nums1[i]);
                    break;
                }
            }
        }
        
        return result.ToArray();
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через словарь и bool ключи.
    /// 1) Создаём результирующий массив минимальной длинны: List(int) result = new(s.Length), s - small и l - large
    /// 2) Проходимся по элементам меньшего массива и создаём их в Dictionary в виде: 2 - false, 1 - false
    /// 3) Теперь проходимся по large массиву и смотрим в Dictionary, если элемент есть и мы его не добавили в result
    /// </summary>
    /// <param name="nums1">[2,1]</param>
    /// <param name="nums2">[1,2]</param>
    /// <returns>[1,2]</returns>
    public int[] IntersectionBestSpeed(int[] nums1, int[] nums2)
    {
        (int[] s, int[] l) = nums1.Length > nums2.Length ? (nums2, nums1) : (nums1, nums2);

        List<int> result = new(s.Length);
        var cache = new Dictionary<int, bool>(s.Length);

        foreach(var value in s) cache[value] = false;
        foreach(var value in l)
            if(cache.TryGetValue(value, out bool flag) && !flag)
            {
                cache[value] = true;
                result.Add(value);
            }

        return result.ToArray();
    }
}