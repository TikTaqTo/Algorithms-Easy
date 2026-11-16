namespace Algorithms_Easy;

/// <summary>
/// 2570. Merge Two 2D Arrays by Summing Values
/// You are given two 2D integer arrays nums1 and nums2.
/// nums1[i] = [idi, vali] indicate that the number with the id idi has a value equal to vali.
/// nums2[i] = [idi, vali] indicate that the number with the id idi has a value equal to vali.
/// Each array contains unique ids and is sorted in ascending order by id.
/// Merge the two arrays into one array that is sorted in ascending order by id, respecting the following conditions:
/// Only ids that appear in at least one of the two arrays should be included in the resulting array.
/// Each id should be included only once and its value should be the sum of the values of this id in the two arrays. If the id does not exist in one of the two arrays, then assume its value in that array to be 0.
/// Return the resulting array. The returned array must be sorted in ascending order by id.
/// </summary>
public class MergeTwo2DArraysBySummingValues
{
    /// <summary>
    /// Standart(Базовое решение). Решаем через SortedDictionary
    /// 1) Добавляем все элементы из nums1, проверок нет ведь индексы внутри массива уникальны
    /// 2) Проходимся по nums2 но делаем проверки ведь индексы могут пересекаться
    /// 3) Переносим из SortedDictionary в int[][] что бы вернуть результат
    /// </summary>
    /// <param name="nums1">[[1,2],[2,3],[4,5]]</param>
    /// <param name="nums2">[[1,4],[3,2],[4,1]]</param>
    /// <returns>[[1,6],[2,3],[3,2],[4,6]]</returns>
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) 
    {
        int index = 0;
        int value = 1;
        SortedDictionary<int, int> normalizedNums = new SortedDictionary<int, int>();

        for (int i = 0; i < nums1.Length; i++)
            normalizedNums.Add(nums1[i][index], nums1[i][value]);
        
        for (int i = 0; i < nums2.Length; i++)
        {
            if (normalizedNums.ContainsKey(nums2[i][0]))
                normalizedNums[nums2[i][index]] += nums2[i][value];
            else
                normalizedNums.Add(nums2[i][index], nums2[i][value]);
        }
        
        int[][] result = new int[normalizedNums.Count][];
        int j = 0;

        foreach(KeyValuePair<int, int> num in normalizedNums)
        {
            result[j] = [num.Key, num.Value];
            j++;
        }

        return result;
    }
}