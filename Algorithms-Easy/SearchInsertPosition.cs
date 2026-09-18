namespace Algorithms_Easy;

/// <summary>
/// 35. Search Insert Position
/// Given a sorted array of distinct integers and a target value, return the index if the target is found.
/// If not, return the index where it would be if it were inserted in order.
/// You must write an algorithm with O(log n) runtime complexity.
/// </summary>
public class SearchInsertPosition
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости). Ищем число через 2 указателя less и greater и постоянно двигаем указатели, ведь массив отсортирован
    /// и мы найдём местоположение target в nums.length/2 засчёт этих 2 указателей.
    /// </summary>
    /// <param name="nums">[1,3,5,6]</param>
    /// <param name="target">3</param>
    /// <returns>1</returns>
    public int SearchInsert(int[] nums, int target) {
        for (int less = 0, greater = nums.Length - 1; less <= nums.Length / 2; less++, greater--)
        {
            if (nums[greater] == target)
                return greater;

            if (nums[greater] < target)
                return greater + 1;
            
            if (nums[less] == target || nums[less] > target)
                return less;
        }

        return -1;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Лучшее решение по скорости, делает то же что в Standart
    /// только указатели идут не с краёв less и greater а с середины mid.
    /// </summary>
    /// <param name="nums">[1,3,5,6]</param>
    /// <param name="target">3</param>
    /// <returns>1</returns>
    public int SearchInsertBestSpeed(int[] nums, int target) {
        if(target < nums[0]) return 0;
        if(target > nums[nums.Length - 1]) return nums.Length;

        int s = 0;
        int e = nums.Length - 1;
        int result = 0;

        while(s<=e) {

            int mid = s + (e-s) / 2;

            if(IsValid(nums[mid], target)) {
                s = mid + 1;
                result = mid;
            } else {
                e = mid - 1;
            }

        }

        return (nums[result] == target) ? result : (result+1);

    }

    public bool IsValid(int num, int target) {
        return (num <= target);
    }
}