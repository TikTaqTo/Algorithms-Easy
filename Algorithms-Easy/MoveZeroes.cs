namespace Algorithms_Easy;

/// <summary>
/// 283. Move Zeroes
/// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
/// Note that you must do this in-place without making a copy of the array.
/// Follow up: Could you minimize the total number of operations done?
/// </summary>
public class MoveZeroes
{
    /// <summary>
    /// Standart(Базовое решение). Решаем через 2 указателя, i первым, j вторым.
    /// 1) i всегда должен искать 0
    /// 2) j всегда должен искать число кроме 0
    /// </summary>
    /// <param name="nums">[0,1,0,3,12]</param>
    public void MoveZeroesAnswer(int[] nums) 
    {
        for (int i = 0, j = i + 1; j <= nums.Length-1 && i < j;)
        {
            if (nums[i] != 0)
                i++;

            if (nums[j] == 0 || j <= i)
                j++;
            
            if (j <= nums.Length-1 && nums[i] == 0 && nums[j] != 0)
            {
                nums[i] = nums[j];
                nums[j] = 0;
                i++;
                j++;
            }
        }
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решаем через 2 указателя.
    /// </summary>
    /// <param name="nums">[0,1,0,3,12]</param>
    public void MoveZeroesAnswerBestSpeed(int[] nums) 
    {
        int n=nums.Length;
        int i=0,j=0;
        while(j<n){
            if(nums[j]!=0){
                int temp=nums[i];
                nums[i]=nums[j];
                nums[j]=temp;
                i++;
                j++;
            }
            else{
                j++;
            }
        }
    }
}