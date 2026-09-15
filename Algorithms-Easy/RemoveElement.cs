namespace Algorithms_Easy;

/// <summary>
/// 27. Remove Element
/// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
/// The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
/// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
/// Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
/// Return k.
/// </summary>
public class RemoveElement
{
    /// <summary>
    /// Standart(Базовое решение). Пускаем в ход 2 указателя startPointer и endPointer,
    /// в случае дубликата меняем местами endPointer не дублирующую цифру с startPointer дубликатом.
    /// </summary>
    /// <param name="nums">[3,2,2,3]</param>
    /// <param name="val">3</param>
    /// <returns>2</returns>
    public int RemoveElementAnswer(int[] nums, int val)
    {
        int k = 0;

        for (int startPointer = 0, endPointer = nums.Length - 1; startPointer <= endPointer; startPointer++)
        {
            if (nums[startPointer] == val)
            {
                for (; endPointer > startPointer; endPointer--)
                {
                    if (nums[endPointer] != val)
                    {
                        nums[startPointer] = nums[endPointer];
                        nums[endPointer] = val;
                        k++;
                        break;
                    }
                }
            }
            else
            {
                k++;
            }
        }
        
        return k;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Лучшее решение по скорости, не менять местами а присваивать актуальные значения в начало.
    /// </summary>
    /// <param name="nums">[3,2,2,3]</param>
    /// <param name="val">3</param>
    /// <returns>2</returns>
    public int RemoveElementAnswerBestSpeed(int[] nums, int val)
    {
        int k = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}