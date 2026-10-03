namespace Algorithms_Easy;

/// <summary>
/// 350. Intersection of Two Arrays II
/// Given two integer arrays nums1 and nums2, return an array of their intersection.
/// Each element in the result must be unique and you may return the result in any order.
/// </summary>
public class IntersectionOfTwoArrays2
{
    /// <summary>
    /// Standart(Базовое решение). Решаем через Dictionary и подсчёт колличество повторений.
    /// </summary>
    /// <param name="nums1">[2,1]</param>
    /// <param name="nums2">[1,2]</param>
    /// <returns>[1,2]</returns>
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        List<int> result = new List<int>();

        foreach (int num in nums1)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

        foreach (int num in nums2)
        {
            if (counts.ContainsKey(num) && counts[num] > 0)
            {
                result.Add(num);
                counts[num]--;
            }
        }

        return result.ToArray();
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Логика решение та же что и выше, только вместо Dictionary используем массив.
    /// </summary>
    /// <param name="nums1">[2,1]</param>
    /// <param name="nums2">[1,2]</param>
    /// <returns>[1,2]</returns>
    public int[] IntersectionBestSpeed(int[] nums1, int[] nums2)
    {
        int[] arr1 = new int[1001];
        int[] arr2 = new int[1001];
        var res = new List<int>();
        foreach(int i in nums1){
            arr1[i]++;
        }
        foreach(int i in nums2){
            arr2[i]++;
        }

        foreach(int i in (nums1)){
            if(arr1[i]>=1&&arr2[i]>=1){
                res.Add(i);
                arr1[i]--;
                arr2[i]--;
            }
        }
        return res.ToArray();
    }
}