namespace Algorithms_Easy;

/// <summary>
/// 70. Climbing Stairs
/// You are climbing a staircase. It takes n steps to reach the top.
/// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
/// </summary>
public class ClimbingStairs
{
    
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости). Решение через вычисление приведущих результатов,
    /// то есть попасть на любую ступень можно по формуле: point[i] = point[i - 1] + point[i - 2]
    /// Задача похожа на вычисление числа Фибоначи, где нам известно что базовые случай point[0] = 0 и point[1] = 1 а все остальные
    /// вычисляются по формуле: Fib(n - 1) + Fib(n - 2)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int ClimbStairs(int n)
    {
        int prev2 = 1;
        int prev1 = 1;

        for (int i = 2; i <= n; i++)
        {
            int curr = prev1 + prev2;
            prev2 = prev1;
            prev1 = curr;
        }

        return prev1;
    }
}