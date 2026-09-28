namespace Algorithms_Easy;

/// <summary>
/// 202. Happy Number
/// Write an algorithm to determine if a number n is happy.
/// A happy number is a number defined by the following process:
/// Starting with any positive integer, replace the number by the sum of the squares of its digits.
/// Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
/// Those numbers for which this process ends in 1 are happy.
/// Return true if n is a happy number, and false if not.
/// </summary>
public class HappyNumber
{
    /// <summary>
    /// Standart(Базовое решение). Решение через мат формулу и константу что если сумма ровна 4
    /// она никогда не доберёться до единички.
    /// </summary>
    /// <param name="n">19</param>
    /// <returns>true</returns>
    public bool IsHappy(int n)
    {
        int sum = n;
        
        while (sum != 4)
        {
            int[] digits = sum.ToString()
                .Select(c => int.Parse(c.ToString()))
                .ToArray();
            sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i] * digits[i];
            }

            if (sum == 1)
                return true;
        }

        return false;
    }
    
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Используется паттерн для обнаружения цикла, через быстрый и медленный указатель,
    /// если они пересекаются, значит число не дойдёт до единицы. 
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool IsHappyBestSpeed(int n) {
        int slow = n;
        int fast = GetNext(n);
        
        while (fast != 1 && slow != fast) {
            slow = GetNext(slow);
            fast = GetNext(GetNext(fast));
        }

        return fast == 1;
    }
    
    private int GetNext(int n) {
        int sum = 0;
        while (n > 0) {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}