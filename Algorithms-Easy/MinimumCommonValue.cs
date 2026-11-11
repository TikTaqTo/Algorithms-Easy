namespace Algorithms_Easy;

/// <summary>
/// 2540. Minimum Common Value
/// Given two integer arrays nums1 and nums2, sorted in non-decreasing order, return the minimum integer common to both arrays.
/// If there is no common integer amongst nums1 and nums2, return -1.
/// Note that an integer is said to be common to nums1 and nums2 if both arrays have at least one occurrence of that integer.
/// </summary>
public class MinimumCommonValue
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости). Решение через 2 указателя.
    /// 1) Массив отсортирован, по этому мы можем сравнивать значения между nums1[i] и nums2[j] и подтягивать меньшее
    /// </summary>
    /// <param name="nums1">[1,1,2]</param>
    /// <param name="nums2">[2,4]</param>
    /// <returns>2</returns>
    public int GetCommon(int[] nums1, int[] nums2)
    {
        for (int i = 0, j = 0; i < nums1.Length && j < nums2.Length;)
        {
            if (nums1[i] == nums2[j])
                return nums1[i];
            
            if (nums1[i] < nums2[j])
                i++;
            else
                j++;
        }

        return -1;
    }
}